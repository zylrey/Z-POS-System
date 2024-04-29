<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
		Me.components = New System.ComponentModel.Container()
		Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.btnAddItem = New DevExpress.XtraBars.BarButtonItem()
		Me.btnReport = New DevExpress.XtraBars.BarButtonItem()
		Me.btnStocks = New DevExpress.XtraBars.BarButtonItem()
		Me.btnGenerateBC = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCalculator = New DevExpress.XtraBars.BarButtonItem()
		Me.btnAddUser = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCashier = New DevExpress.XtraBars.BarButtonItem()
		Me.btnCustomer = New DevExpress.XtraBars.BarButtonItem()
		Me.btnLogout = New DevExpress.XtraBars.BarButtonItem()
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
		Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonControl
		'
		Me.RibbonControl.ExpandCollapseItem.Id = 0
		Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnAddItem, Me.btnReport, Me.btnStocks, Me.btnGenerateBC, Me.btnCalculator, Me.btnAddUser, Me.btnCashier, Me.btnCustomer, Me.btnLogout})
		Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
		Me.RibbonControl.MaxItemId = 10
		Me.RibbonControl.Name = "RibbonControl"
		Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
		Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
		Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
		Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
		Me.RibbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
		Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
		Me.RibbonControl.ShowToolbarCustomizeItem = False
		Me.RibbonControl.Size = New System.Drawing.Size(715, 126)
		Me.RibbonControl.StatusBar = Me.RibbonStatusBar
		Me.RibbonControl.Toolbar.ShowCustomizeItem = False
		'
		'btnAddItem
		'
		Me.btnAddItem.Caption = "Add Item"
		Me.btnAddItem.Glyph = Global.Z_POS_System.My.Resources.Resources.add_16x16
		Me.btnAddItem.Id = 1
		Me.btnAddItem.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.add_32x32
		Me.btnAddItem.Name = "btnAddItem"
		'
		'btnReport
		'
		Me.btnReport.Caption = "Sales Report"
		Me.btnReport.Glyph = Global.Z_POS_System.My.Resources.Resources.boreport2_16x16
		Me.btnReport.Id = 2
		Me.btnReport.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.boreport2_32x32
		Me.btnReport.Name = "btnReport"
		'
		'btnStocks
		'
		Me.btnStocks.Caption = "Stocks"
		Me.btnStocks.Glyph = Global.Z_POS_System.My.Resources.Resources.boproductgroup_16x16
		Me.btnStocks.Id = 3
		Me.btnStocks.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.boproductgroup_32x32
		Me.btnStocks.Name = "btnStocks"
		'
		'btnGenerateBC
		'
		Me.btnGenerateBC.Caption = "Generate Barcode"
		Me.btnGenerateBC.Glyph = Global.Z_POS_System.My.Resources.Resources.barcode2_16x16
		Me.btnGenerateBC.Id = 4
		Me.btnGenerateBC.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.barcode2_32x32
		Me.btnGenerateBC.Name = "btnGenerateBC"
		'
		'btnCalculator
		'
		Me.btnCalculator.Caption = "Calculator"
		Me.btnCalculator.Glyph = Global.Z_POS_System.My.Resources.Resources.calculatenow_16x16
		Me.btnCalculator.Id = 5
		Me.btnCalculator.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.calculatenow_32x32
		Me.btnCalculator.Name = "btnCalculator"
		'
		'btnAddUser
		'
		Me.btnAddUser.Caption = "Add User"
		Me.btnAddUser.Glyph = Global.Z_POS_System.My.Resources.Resources.bouser_16x16
		Me.btnAddUser.Id = 6
		Me.btnAddUser.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.bouser_32x32
		Me.btnAddUser.Name = "btnAddUser"
		'
		'btnCashier
		'
		Me.btnCashier.Caption = "Cashier Report"
		Me.btnCashier.Glyph = Global.Z_POS_System.My.Resources.Resources.bodetails_16x16
		Me.btnCashier.Id = 7
		Me.btnCashier.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.bodetails_32x32
		Me.btnCashier.Name = "btnCashier"
		'
		'btnCustomer
		'
		Me.btnCustomer.Caption = "Customer Info"
		Me.btnCustomer.Glyph = Global.Z_POS_System.My.Resources.Resources.boperson_16x16
		Me.btnCustomer.Id = 8
		Me.btnCustomer.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.boperson_32x32
		Me.btnCustomer.Name = "btnCustomer"
		'
		'btnLogout
		'
		Me.btnLogout.Caption = "Logout"
		Me.btnLogout.Glyph = Global.Z_POS_System.My.Resources.Resources.cancel_16x16
		Me.btnLogout.Id = 9
		Me.btnLogout.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.cancel_32x32
		Me.btnLogout.Name = "btnLogout"
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "RibbonPage1"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.AllowTextClipping = False
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddItem)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnReport)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnStocks)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGenerateBC)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCalculator)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddUser)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCashier)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCustomer)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		Me.RibbonPageGroup1.ShowCaptionButton = False
		'
		'RibbonPageGroup2
		'
		Me.RibbonPageGroup2.AllowTextClipping = False
		Me.RibbonPageGroup2.ItemLinks.Add(Me.btnLogout)
		Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
		Me.RibbonPageGroup2.ShowCaptionButton = False
		'
		'RibbonStatusBar
		'
		Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 420)
		Me.RibbonStatusBar.Name = "RibbonStatusBar"
		Me.RibbonStatusBar.Ribbon = Me.RibbonControl
		Me.RibbonStatusBar.Size = New System.Drawing.Size(715, 23)
		'
		'DefaultLookAndFeel1
		'
		Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(715, 443)
		Me.Controls.Add(Me.RibbonStatusBar)
		Me.Controls.Add(Me.RibbonControl)
		Me.Name = "frmMain"
		Me.Ribbon = Me.RibbonControl
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.StatusBar = Me.RibbonStatusBar
		Me.Text = "frmMain"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
	Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
	Friend WithEvents btnAddItem As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnReport As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnStocks As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnGenerateBC As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnCalculator As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnAddUser As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnCashier As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnCustomer As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents btnLogout As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup


End Class
