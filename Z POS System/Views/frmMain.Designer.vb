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
		Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RibbonControl
		'
		Me.RibbonControl.ExpandCollapseItem.Id = 0
		Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1})
		Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
		Me.RibbonControl.MaxItemId = 2
		Me.RibbonControl.Name = "RibbonControl"
		Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
		Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
		Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
		Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
		Me.RibbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
		Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
		Me.RibbonControl.ShowToolbarCustomizeItem = False
		Me.RibbonControl.Size = New System.Drawing.Size(634, 122)
		Me.RibbonControl.StatusBar = Me.RibbonStatusBar
		Me.RibbonControl.Toolbar.ShowCustomizeItem = False
		'
		'RibbonPage1
		'
		Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
		Me.RibbonPage1.Name = "RibbonPage1"
		Me.RibbonPage1.Text = "RibbonPage1"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.AllowTextClipping = False
		Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		Me.RibbonPageGroup1.ShowCaptionButton = False
		'
		'RibbonStatusBar
		'
		Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 312)
		Me.RibbonStatusBar.Name = "RibbonStatusBar"
		Me.RibbonStatusBar.Ribbon = Me.RibbonControl
		Me.RibbonStatusBar.Size = New System.Drawing.Size(634, 31)
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "Main"
		Me.BarButtonItem1.Glyph = Global.Z_POS_System.My.Resources.Resources.calculatesheet_16x16
		Me.BarButtonItem1.Id = 1
		Me.BarButtonItem1.LargeGlyph = Global.Z_POS_System.My.Resources.Resources.calculatesheet_32x32
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(634, 343)
		Me.Controls.Add(Me.RibbonStatusBar)
		Me.Controls.Add(Me.RibbonControl)
		Me.Name = "frmMain"
		Me.Ribbon = Me.RibbonControl
		Me.StatusBar = Me.RibbonStatusBar
		Me.Text = "frmMain"
		CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
	Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem


End Class
