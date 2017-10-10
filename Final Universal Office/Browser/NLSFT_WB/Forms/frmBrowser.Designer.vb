<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowser))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPage = New System.Windows.Forms.ToolStripMenuItem
        Me.SendToToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPageNewTab = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuPageToDesktop = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator
        Me.AdToFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuPageSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSaveAllImages = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuPagePrintSetup = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPagePrint = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPagePrintPreview = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuLeftToRight = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightToLeft = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuLink = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuLinkNewTab = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCopyLink = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator
        Me.PrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuImage = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuImageSave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuViewImageNewTab = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuImageCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuImageProperties = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuForward = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuShowRuler = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ElemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmRuler = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuShowLabels = New System.Windows.Forms.ToolStripMenuItem
        Me.muShowBorder = New System.Windows.Forms.ToolStripMenuItem
        Me.DrawModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopOnly = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBottomOnly = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTopandBottom = New System.Windows.Forms.ToolStripMenuItem
        Me.cmiInfoBar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPopTempAllow = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPopAllowthissite = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPopBlockEnabled = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPopShowInfoBar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPopMoreSettings = New System.Windows.Forms.ToolStripMenuItem
        Me.wb = New NLSFT_WB.exBrowser
        Me.Ruler1 = New NLSFT_WB.Ruler
        Me.InfoBar1 = New NLSFT_WB.InfoBar
        Me.ContextMenuStrip1.SuspendLayout()
        Me.cmRuler.SuspendLayout()
        Me.cmiInfoBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPage, Me.ToolStripMenuItem1, Me.mnuLink, Me.ToolStripMenuItem14, Me.mnuImage, Me.ToolStripMenuItem15, Me.mnuBack, Me.mnuForward, Me.mnuRefresh, Me.ToolStripMenuItem17, Me.mnuShowRuler, Me.ToolStripMenuItem21, Me.mnuCopy, Me.mnuPaste, Me.ToolStripMenuItem2, Me.ElemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 320)
        '
        'mnuPage
        '
        Me.mnuPage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToToolStripMenuItem1, Me.ToolStripMenuItem12, Me.AdToFavoritesToolStripMenuItem, Me.ToolStripMenuItem16, Me.mnuPageSaveAs, Me.mnuSaveAllImages, Me.SaveAsImageToolStripMenuItem, Me.ToolStripMenuItem4, Me.mnuPagePrintSetup, Me.mnuPagePrint, Me.mnuPagePrintPreview, Me.ToolStripMenuItem11, Me.mnuFind, Me.ToolStripMenuItem3, Me.PropertiesToolStripMenuItem, Me.ToolStripMenuItem7, Me.mnuLeftToRight, Me.mnuRightToLeft, Me.ToolStripMenuItem8})
        Me.mnuPage.Image = Global.NLSFT_WB.My.Resources.Resources.page16
        Me.mnuPage.Name = "mnuPage"
        Me.mnuPage.Size = New System.Drawing.Size(181, 28)
        Me.mnuPage.Text = "Page"
        '
        'SendToToolStripMenuItem1
        '
        Me.SendToToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPageNewTab, Me.ToolStripMenuItem6, Me.mnuPageToDesktop})
        Me.SendToToolStripMenuItem1.Name = "SendToToolStripMenuItem1"
        Me.SendToToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.SendToToolStripMenuItem1.Text = "Send to"
        '
        'mnuPageNewTab
        '
        Me.mnuPageNewTab.Image = Global.NLSFT_WB.My.Resources.Resources.tab_icon
        Me.mnuPageNewTab.Name = "mnuPageNewTab"
        Me.mnuPageNewTab.Size = New System.Drawing.Size(127, 22)
        Me.mnuPageNewTab.Text = "New Tab"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(124, 6)
        '
        'mnuPageToDesktop
        '
        Me.mnuPageToDesktop.Name = "mnuPageToDesktop"
        Me.mnuPageToDesktop.Size = New System.Drawing.Size(127, 22)
        Me.mnuPageToDesktop.Text = "Desktop"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(178, 6)
        '
        'AdToFavoritesToolStripMenuItem
        '
        Me.AdToFavoritesToolStripMenuItem.Image = Global.NLSFT_WB.My.Resources.Resources.addfav
        Me.AdToFavoritesToolStripMenuItem.Name = "AdToFavoritesToolStripMenuItem"
        Me.AdToFavoritesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AdToFavoritesToolStripMenuItem.Text = "Add to Favorites"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(178, 6)
        '
        'mnuPageSaveAs
        '
        Me.mnuPageSaveAs.Image = Global.NLSFT_WB.My.Resources.Resources._553_1
        Me.mnuPageSaveAs.Name = "mnuPageSaveAs"
        Me.mnuPageSaveAs.Size = New System.Drawing.Size(181, 22)
        Me.mnuPageSaveAs.Text = "Save As..."
        '
        'mnuSaveAllImages
        '
        Me.mnuSaveAllImages.Name = "mnuSaveAllImages"
        Me.mnuSaveAllImages.Size = New System.Drawing.Size(181, 22)
        Me.mnuSaveAllImages.Text = "Save All Images"
        '
        'SaveAsImageToolStripMenuItem
        '
        Me.SaveAsImageToolStripMenuItem.Name = "SaveAsImageToolStripMenuItem"
        Me.SaveAsImageToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SaveAsImageToolStripMenuItem.Text = "Save As Image"
        Me.SaveAsImageToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(178, 6)
        '
        'mnuPagePrintSetup
        '
        Me.mnuPagePrintSetup.Name = "mnuPagePrintSetup"
        Me.mnuPagePrintSetup.Size = New System.Drawing.Size(181, 22)
        Me.mnuPagePrintSetup.Text = "Page Setup"
        '
        'mnuPagePrint
        '
        Me.mnuPagePrint.Image = Global.NLSFT_WB.My.Resources.Resources.i_print
        Me.mnuPagePrint.Name = "mnuPagePrint"
        Me.mnuPagePrint.Size = New System.Drawing.Size(181, 22)
        Me.mnuPagePrint.Text = "Print..."
        '
        'mnuPagePrintPreview
        '
        Me.mnuPagePrintPreview.Name = "mnuPagePrintPreview"
        Me.mnuPagePrintPreview.Size = New System.Drawing.Size(181, 22)
        Me.mnuPagePrintPreview.Text = "Print Preview..."
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(178, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Image = Global.NLSFT_WB.My.Resources.Resources.it_search0
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(181, 22)
        Me.mnuFind.Text = "Find On this page..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(178, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Image = Global.NLSFT_WB.My.Resources.Resources.Properties
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(178, 6)
        '
        'mnuLeftToRight
        '
        Me.mnuLeftToRight.Checked = True
        Me.mnuLeftToRight.CheckOnClick = True
        Me.mnuLeftToRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuLeftToRight.Name = "mnuLeftToRight"
        Me.mnuLeftToRight.Size = New System.Drawing.Size(181, 22)
        Me.mnuLeftToRight.Text = "Left To Right"
        '
        'mnuRightToLeft
        '
        Me.mnuRightToLeft.CheckOnClick = True
        Me.mnuRightToLeft.Name = "mnuRightToLeft"
        Me.mnuRightToLeft.Size = New System.Drawing.Size(181, 22)
        Me.mnuRightToLeft.Text = "Right To Left"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(178, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        'mnuLink
        '
        Me.mnuLink.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLinkNewTab, Me.ToolStripMenuItem19, Me.mnuCopyLink, Me.ToolStripMenuItem20, Me.PrToolStripMenuItem})
        Me.mnuLink.Name = "mnuLink"
        Me.mnuLink.Size = New System.Drawing.Size(181, 28)
        Me.mnuLink.Text = "Link"
        '
        'mnuLinkNewTab
        '
        Me.mnuLinkNewTab.Name = "mnuLinkNewTab"
        Me.mnuLinkNewTab.Size = New System.Drawing.Size(167, 22)
        Me.mnuLinkNewTab.Text = "Open in New Tab"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(164, 6)
        '
        'mnuCopyLink
        '
        Me.mnuCopyLink.Name = "mnuCopyLink"
        Me.mnuCopyLink.Size = New System.Drawing.Size(167, 22)
        Me.mnuCopyLink.Text = "Copy Link"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(164, 6)
        '
        'PrToolStripMenuItem
        '
        Me.PrToolStripMenuItem.Name = "PrToolStripMenuItem"
        Me.PrToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PrToolStripMenuItem.Text = "Properties"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(178, 6)
        '
        'mnuImage
        '
        Me.mnuImage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuImageSave, Me.ToolStripMenuItem9, Me.mnuViewImageNewTab, Me.ToolStripMenuItem5, Me.mnuImageCopy, Me.ToolStripMenuItem18, Me.mnuImageProperties})
        Me.mnuImage.Name = "mnuImage"
        Me.mnuImage.Size = New System.Drawing.Size(181, 28)
        Me.mnuImage.Text = "Image"
        '
        'mnuImageSave
        '
        Me.mnuImageSave.Name = "mnuImageSave"
        Me.mnuImageSave.Size = New System.Drawing.Size(163, 22)
        Me.mnuImageSave.Text = "Save As..."
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(160, 6)
        '
        'mnuViewImageNewTab
        '
        Me.mnuViewImageNewTab.Name = "mnuViewImageNewTab"
        Me.mnuViewImageNewTab.Size = New System.Drawing.Size(163, 22)
        Me.mnuViewImageNewTab.Text = "View in New Tab"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(160, 6)
        '
        'mnuImageCopy
        '
        Me.mnuImageCopy.Name = "mnuImageCopy"
        Me.mnuImageCopy.Size = New System.Drawing.Size(163, 22)
        Me.mnuImageCopy.Text = "Copy"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(160, 6)
        '
        'mnuImageProperties
        '
        Me.mnuImageProperties.Name = "mnuImageProperties"
        Me.mnuImageProperties.Size = New System.Drawing.Size(163, 22)
        Me.mnuImageProperties.Text = "Properties"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(178, 6)
        '
        'mnuBack
        '
        Me.mnuBack.Image = Global.NLSFT_WB.My.Resources.Resources.Back
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(181, 28)
        Me.mnuBack.Text = "Back"
        '
        'mnuForward
        '
        Me.mnuForward.Image = Global.NLSFT_WB.My.Resources.Resources.Forward
        Me.mnuForward.Name = "mnuForward"
        Me.mnuForward.Size = New System.Drawing.Size(181, 28)
        Me.mnuForward.Text = "Forward"
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Image = Global.NLSFT_WB.My.Resources.Resources.refresh16
        Me.mnuRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuRefresh.ImageTransparentColor = System.Drawing.Color.White
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.Size = New System.Drawing.Size(181, 28)
        Me.mnuRefresh.Text = "Refresh"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(178, 6)
        '
        'mnuShowRuler
        '
        Me.mnuShowRuler.CheckOnClick = True
        Me.mnuShowRuler.Name = "mnuShowRuler"
        Me.mnuShowRuler.Size = New System.Drawing.Size(181, 28)
        Me.mnuShowRuler.Text = "Show Ruler"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(178, 6)
        '
        'mnuCopy
        '
        Me.mnuCopy.Image = Global.NLSFT_WB.My.Resources.Resources.Copy
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(181, 28)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Image = Global.NLSFT_WB.My.Resources.Resources.Paste
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(181, 28)
        Me.mnuPaste.Text = "Paste"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'ElemToolStripMenuItem
        '
        Me.ElemToolStripMenuItem.Image = Global.NLSFT_WB.My.Resources.Resources.Properties
        Me.ElemToolStripMenuItem.Name = "ElemToolStripMenuItem"
        Me.ElemToolStripMenuItem.Size = New System.Drawing.Size(181, 28)
        Me.ElemToolStripMenuItem.Text = "Element Properties"
        '
        'cmRuler
        '
        Me.cmRuler.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowLabels, Me.muShowBorder, Me.DrawModeToolStripMenuItem})
        Me.cmRuler.Name = "cmRuler"
        Me.cmRuler.Size = New System.Drawing.Size(147, 70)
        '
        'mnuShowLabels
        '
        Me.mnuShowLabels.CheckOnClick = True
        Me.mnuShowLabels.Name = "mnuShowLabels"
        Me.mnuShowLabels.Size = New System.Drawing.Size(146, 22)
        Me.mnuShowLabels.Text = "Show Labels"
        '
        'muShowBorder
        '
        Me.muShowBorder.CheckOnClick = True
        Me.muShowBorder.Name = "muShowBorder"
        Me.muShowBorder.Size = New System.Drawing.Size(146, 22)
        Me.muShowBorder.Text = "Show Border"
        '
        'DrawModeToolStripMenuItem
        '
        Me.DrawModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopOnly, Me.mnuBottomOnly, Me.mnuTopandBottom})
        Me.DrawModeToolStripMenuItem.Name = "DrawModeToolStripMenuItem"
        Me.DrawModeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DrawModeToolStripMenuItem.Text = "Draw Mode"
        '
        'mnuTopOnly
        '
        Me.mnuTopOnly.Checked = True
        Me.mnuTopOnly.CheckOnClick = True
        Me.mnuTopOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuTopOnly.Name = "mnuTopOnly"
        Me.mnuTopOnly.Size = New System.Drawing.Size(161, 22)
        Me.mnuTopOnly.Text = "Top Only"
        '
        'mnuBottomOnly
        '
        Me.mnuBottomOnly.CheckOnClick = True
        Me.mnuBottomOnly.Name = "mnuBottomOnly"
        Me.mnuBottomOnly.Size = New System.Drawing.Size(161, 22)
        Me.mnuBottomOnly.Text = "Bottom Only"
        '
        'mnuTopandBottom
        '
        Me.mnuTopandBottom.CheckOnClick = True
        Me.mnuTopandBottom.Name = "mnuTopandBottom"
        Me.mnuTopandBottom.Size = New System.Drawing.Size(161, 22)
        Me.mnuTopandBottom.Text = "Top and Bottom"
        '
        'cmiInfoBar
        '
        Me.cmiInfoBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPopTempAllow, Me.mnuPopAllowthissite, Me.SettingsToolStripMenuItem})
        Me.cmiInfoBar.Name = "cmiInfoBar"
        Me.cmiInfoBar.Size = New System.Drawing.Size(262, 70)
        '
        'mnuPopTempAllow
        '
        Me.mnuPopTempAllow.Name = "mnuPopTempAllow"
        Me.mnuPopTempAllow.Size = New System.Drawing.Size(261, 22)
        Me.mnuPopTempAllow.Text = "Temporarily Allow PopUps"
        '
        'mnuPopAllowthissite
        '
        Me.mnuPopAllowthissite.Name = "mnuPopAllowthissite"
        Me.mnuPopAllowthissite.Size = New System.Drawing.Size(261, 22)
        Me.mnuPopAllowthissite.Text = "Always allow popups from this site..."
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPopBlockEnabled, Me.mnuPopShowInfoBar, Me.mnuPopMoreSettings})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'mnuPopBlockEnabled
        '
        Me.mnuPopBlockEnabled.Name = "mnuPopBlockEnabled"
        Me.mnuPopBlockEnabled.Size = New System.Drawing.Size(208, 22)
        Me.mnuPopBlockEnabled.Text = "Turn Off Popup Blocker"
        '
        'mnuPopShowInfoBar
        '
        Me.mnuPopShowInfoBar.Name = "mnuPopShowInfoBar"
        Me.mnuPopShowInfoBar.Size = New System.Drawing.Size(208, 22)
        Me.mnuPopShowInfoBar.Text = "Show Info Bar for popups"
        '
        'mnuPopMoreSettings
        '
        Me.mnuPopMoreSettings.Name = "mnuPopMoreSettings"
        Me.mnuPopMoreSettings.Size = New System.Drawing.Size(208, 22)
        Me.mnuPopMoreSettings.Text = "More settings..."
        '
        'wb
        '
        Me.wb.ContextMenuStrip = Me.ContextMenuStrip1
        Me.wb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb.IsWebBrowserContextMenuEnabled = False
        Me.wb.Location = New System.Drawing.Point(0, 49)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.ScriptErrorsSuppressed = True
        Me.wb.Size = New System.Drawing.Size(616, 387)
        Me.wb.TabIndex = 1
        '
        'Ruler1
        '
        Me.Ruler1.BackgroundImage = Global.NLSFT_WB.My.Resources.Resources.white_bg1
        Me.Ruler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ruler1.ContextMenuStrip = Me.cmRuler
        Me.Ruler1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ruler1.DrawLabels = False
        Me.Ruler1.DrawMode = NLSFT_WB.Ruler.DrawModes.TopOnly
        Me.Ruler1.Location = New System.Drawing.Point(0, 21)
        Me.Ruler1.Name = "Ruler1"
        Me.Ruler1.PenColor = System.Drawing.Color.Black
        Me.Ruler1.ShowBorder = False
        Me.Ruler1.Size = New System.Drawing.Size(616, 28)
        Me.Ruler1.TabIndex = 2
        Me.Ruler1.Visible = False
        '
        'InfoBar1
        '
        Me.InfoBar1.BackColor = System.Drawing.SystemColors.Info
        Me.InfoBar1.ContextMenuStrip = Me.cmiInfoBar
        Me.InfoBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.InfoBar1.Location = New System.Drawing.Point(0, 0)
        Me.InfoBar1.Name = "InfoBar1"
        Me.InfoBar1.PlaySound = False
        Me.InfoBar1.Size = New System.Drawing.Size(616, 21)
        Me.InfoBar1.TabIndex = 0
        Me.InfoBar1.Visible = False
        '
        'frmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 436)
        Me.Controls.Add(Me.wb)
        Me.Controls.Add(Me.Ruler1)
        Me.Controls.Add(Me.InfoBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBrowser"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.cmRuler.ResumeLayout(False)
        Me.cmiInfoBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfoBar1 As NLSFT_WB.InfoBar
    Friend WithEvents wb As NLSFT_WB.exBrowser
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendToToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPageNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPageToDesktop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdToFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPageSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPagePrintSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPagePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPagePrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLink As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLinkNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCopyLink As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImageSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuImageCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuImageProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuForward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuShowRuler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ElemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewImageNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Ruler1 As NLSFT_WB.Ruler
    Friend WithEvents cmRuler As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuShowLabels As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents muShowBorder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrawModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopOnly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomOnly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopandBottom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLeftToRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightToLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmiInfoBar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPopTempAllow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopAllowthissite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopBlockEnabled As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopShowInfoBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopMoreSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAllImages As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
End Class
