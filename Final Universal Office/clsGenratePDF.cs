using System;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Gios.Pdf;
using System.IO;
using System.Data.SqlClient;

namespace Ribbonpad
{
	class clsGenratePDF
	{
        static ListView PDFlistView = null;
        static DataGridView PDFGridView1 = null, PDFGridView2 = null;
        static int noOfrows = 0, PDFReportNumber = 0;
        static int TotalColumns = 0;
        static int UsingControl = 1;// grid or list
        static ArrayList PDFclolumnHeader = null;
        static string PDFsaveAs = "";
        static int pdf_table_no = 1;
        [STAThread]

        public void GenerateUsingText(string saveAs, RichTextBox inText)
        {
            try
            {
                PdfDocument myPdfDocument = new PdfDocument(PdfDocumentFormat.InCentimeters(21, 29.7));
                PdfImage LogoImage = myPdfDocument.NewImage(@"logo.jpg");
                PdfPage newPdfPage =null;
                int lineNo = 1;
                string text = "";
                PdfTextArea ptasubtext = null;
                for (int i = 0; i < inText.Lines.Length; i++, lineNo++)
                {
                    if (i % 50 == 0)
                    {
                        newPdfPage = myPdfDocument.NewPage();
                        lineNo = 1;
                    }
                    text += "\n" + inText.Lines[i];

                    if (i % 50 == 0 && i != 0)
                    {
                        newPdfPage.Add(LogoImage, 15, 10, 100);
                        ptasubtext = new PdfTextArea(new Font("Verdana", 12, FontStyle.Bold), Color.Black
                                    , new PdfArea(myPdfDocument, 18, 120, 400, 930), ContentAlignment.TopLeft, text);
                        newPdfPage.Add(ptasubtext);
                        newPdfPage.SaveToDocument();
                        text = "";
                    }
                }

                newPdfPage = myPdfDocument.NewPage();
                newPdfPage.Add(LogoImage, 15, 10, 100);
                ptasubtext = new PdfTextArea(new Font("Verdana", 12, FontStyle.Bold), Color.Black
                                    , new PdfArea(myPdfDocument, 18, 120, 400, 930), ContentAlignment.TopLeft, text);
                newPdfPage.Add(ptasubtext);
                newPdfPage.SaveToDocument();

                myPdfDocument.SaveToFile(saveAs);
                MessageBox.Show("PDF Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { }
        }
        
        public  Boolean GenerateUsingList(string saveAs, ListView listView, ArrayList clolumnHeader,int reportNumber)
        {
            PDFlistView = listView;
            TotalColumns = PDFlistView.Columns.Count;
            noOfrows = PDFlistView.Items.Count;
            PDFsaveAs = saveAs;
            PDFclolumnHeader = clolumnHeader;
            UsingControl = 1;
            PDFReportNumber = reportNumber;
            return Generate();
        }
        
        public Boolean Generate()
        {
            pdf_table_no = 1;
            // Starting instantiate the document.
            // Remember to set the Docuement Format. In this case, we specify width and height.
            if (UsingControl == 1)
            {
                int total_grid_exported=0;
                PdfDocument myPdfDocument = new PdfDocument(PdfDocumentFormat.InCentimeters(21, 29.7));

                addTable(myPdfDocument, Table, noOfrows);
                myPdfDocument.SaveToFile(PDFsaveAs);
            }
            else
            {
                PdfDocument myPdfDocument = new PdfDocument(PdfDocumentFormat.InCentimeters(21, 29.7));
                
                if (PDFReportNumber==9)
                    myPdfDocument.SetPageFormat(PdfDocumentFormat.A4_Horizontal);
                if (addTable(myPdfDocument, Table, noOfrows))
                {
                    try
                    {
                        myPdfDocument.SaveToFile("reports/" + PDFsaveAs + ".pdf");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please close the opened pdf.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to generate report."); 
                    return false;
                }
            }

                MessageBox.Show("PDF Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public Boolean addTable(PdfDocument myPdfDocument,DataTable t,int rows)
        {
            try
            {
                // Now we create a Table of 100 lines, 6 columns and 4 points of Padding.
                PdfTable myPdfTable = myPdfDocument.NewTable(new Font("Verdana", 10), rows, TotalColumns, 4);

                // Importing datas from the datatables... (also column names for the headers!)
                myPdfTable.ImportDataTable(t);

                // Sets the format for correct date-time representation
                //myPdfTable.Columns[2].SetContentFormat("{0:dd/MM/yyyy}");

                // Now we set our Graphic Design: Colors and Borders...
                myPdfTable.HeadersRow.SetColors(Color.White, Color.Black);
                myPdfTable.SetColors(Color.Black, Color.White, Color.White);
                myPdfTable.SetBorders(Color.Black, 1, BorderType.CompleteGrid);
                //White
                // Now we set some alignment... for the whole table and then, for a column.
                myPdfTable.SetContentAlignment(ContentAlignment.MiddleLeft);
                myPdfTable.Columns[0].SetContentAlignment(ContentAlignment.MiddleRight);
                myPdfTable.Columns[1].SetContentAlignment(ContentAlignment.MiddleRight);

                // With just one method we can set the proportional width of the columns.
                // It's a "percentage like" assignment, but the sum can be different from 100.

                myPdfTable.SetContentAlignment(ContentAlignment.MiddleRight);
                myPdfTable.SetColumnsWidth(new int[] { 15, 100, 15 });
                myPdfTable.Columns[1].SetContentAlignment(ContentAlignment.MiddleLeft);



                while (!myPdfTable.AllTablePagesCreated)
                {
                    // we create a new page to put the generation of the new TablePage:
                    PdfPage newPdfPage = myPdfDocument.NewPage();
                    PdfTablePage newPdfTablePage = null;


                    newPdfTablePage = myPdfTable.CreateTablePage(new PdfArea(myPdfDocument, 18, 140, 560, 670));
                    System.Drawing.PointF pointS = new PointF(0, 115);
                    System.Drawing.PointF pointE1 = new PointF(1000, 115);
                    System.Drawing.PointF pointE2 = new PointF(595, 115);
                    // nice thing: we can put all the objects in the following lines, so we can have
                    // a great control of layer sequence... 


                    PdfImage LogoImage = myPdfDocument.NewImage(@"logo.jpg");
                    newPdfPage.Add(newPdfTablePage);
                    newPdfPage.Add(LogoImage, 15, 10, 100);
                    PdfLine pdfline = new PdfLine(myPdfDocument, pointS, pointE2, Color.Black, 1);
                    newPdfPage.Add(pdfline);
                    
                    newPdfPage.SaveToDocument();
                    pdf_table_no++;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
            // Finally we save the docuement...
        }

      	#region Rows Datatable Generation
		static System.Random r=new Random();

		static DataTable Table
		{
			get
			{
				DataTable dt=new DataTable();
                int clhcount = 0;
                for (clhcount = 0; clhcount < TotalColumns; clhcount++)
                {
                    dt.Columns.Add("" + PDFclolumnHeader[clhcount]);
                }

                //dt.Columns.Add("T M",typeof(DateTime));
                DataRow dr = null;
                int x = 0;
                  
                    for (x = 0; x < noOfrows; x++)
                    {
                        dr = dt.NewRow();
                        dr[0] = "" + (x + 1);
                        for (clhcount = 1; clhcount < TotalColumns; clhcount++)
                        {
                            dr[clhcount] = PDFlistView.Items[x].SubItems[clhcount].Text;
                        }
                        dt.Rows.Add(dr);
                    }
                
				return dt;
			}
		}
        static DataTable Table2
        {
            get
            {
                DataTable dt = new DataTable();
                int clhcount = 0;
                for (clhcount = 0; clhcount < TotalColumns; clhcount++)
                {
                    dt.Columns.Add("" + PDFclolumnHeader[clhcount]);
                }

                //dt.Columns.Add("T M",typeof(DateTime));
                DataRow dr = null;
                int x = 0;

                if (UsingControl == 2)
                {
                    for (x = 0; x < noOfrows; x++)
                    {
                        dr = dt.NewRow();

                        for (clhcount = 0; clhcount < TotalColumns; clhcount++)
                        {
                            dr[clhcount] = PDFlistView.Items[x].SubItems[clhcount].Text;
                        }

                        dt.Rows.Add(dr);
                    }
                }
                else
                {
                    for (x = 0; x < PDFGridView2.RowCount - 1; x++)
                    {
                        dr = dt.NewRow();
                        dr[0] = "" + (x + 1);
                        for (clhcount = 1; clhcount < TotalColumns; clhcount++)
                        {
                            dr[clhcount] = PDFGridView2.Rows[x].Cells[clhcount].Value;
                        }
                        dt.Rows.Add(dr);
                    }
                }
                return dt;
            }
        }
		#endregion
	}
}
