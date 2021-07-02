<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SurveyNameLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim NetworkLabel As System.Windows.Forms.Label
        Dim ParkLabel As System.Windows.Forms.Label
        Dim SeasonLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim AreaSurveyed_miLabel As System.Windows.Forms.Label
        Dim AverageSearchEffortLabel As System.Windows.Forms.Label
        Dim MethodologyLabel As System.Windows.Forms.Label
        Dim ProtocolVersionLabel As System.Windows.Forms.Label
        Dim ProtocolReferenceCodeLabel As System.Windows.Forms.Label
        Dim PersonnelLabel As System.Windows.Forms.Label
        Dim ReportReferenceCodeLabel As System.Windows.Forms.Label
        Dim ReportLinkLabel As System.Windows.Forms.Label
        Dim DeliverablesDatasetReferenceCodeLabel As System.Windows.Forms.Label
        Dim DataSourceLabel As System.Windows.Forms.Label
        Dim DataResourcesDirectoryLabel As System.Windows.Forms.Label
        Dim AbstractLabel As System.Windows.Forms.Label
        Dim SummaryLabel As System.Windows.Forms.Label
        Dim DatasetProcessingStepsLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Me.MooseDataSet = New Moose_3.MooseDataSet()
        Me.GSPE_SurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_SurveysTableAdapter = New Moose_3.MooseDataSetTableAdapters.GSPE_SurveysTableAdapter()
        Me.TableAdapterManager = New Moose_3.MooseDataSetTableAdapters.TableAdapterManager()
        Me.GSPE_DensityEstimatesTableAdapter = New Moose_3.MooseDataSetTableAdapters.GSPE_DensityEstimatesTableAdapter()
        Me.GSPE_PopulationEstimatesTableAdapter = New Moose_3.MooseDataSetTableAdapters.GSPE_PopulationEstimatesTableAdapter()
        Me.GSPE_ResultsTableAdapter = New Moose_3.MooseDataSetTableAdapters.GSPE_ResultsTableAdapter()
        Me.GSPETableAdapter = New Moose_3.MooseDataSetTableAdapters.GSPETableAdapter()
        Me.GSPE_DensityEstimatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_PopulationEstimatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_ResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.SurveysInventoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSurveyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNetwork = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMethodology = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.SurveyDetailsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.FKGSPEGSPESurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SurveyDetailsPanel = New System.Windows.Forms.Panel()
        Me.SurveyNameTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.NetworkTextBox = New System.Windows.Forms.TextBox()
        Me.ParkTextBox = New System.Windows.Forms.TextBox()
        Me.SeasonTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AreaSurveyed_miTextBox = New System.Windows.Forms.TextBox()
        Me.AverageSearchEffortTextBox = New System.Windows.Forms.TextBox()
        Me.MethodologyTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocolVersionTextBox = New System.Windows.Forms.TextBox()
        Me.ProtocolReferenceCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelTextBox = New System.Windows.Forms.TextBox()
        Me.ReportReferenceCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ReportLinkTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverablesDatasetReferenceCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DataSourceTextBox = New System.Windows.Forms.TextBox()
        Me.DataResourcesDirectoryTextBox = New System.Windows.Forms.TextBox()
        Me.AbstractTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryTextBox = New System.Windows.Forms.TextBox()
        Me.DatasetProcessingStepsTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SurveyNameHeaderLabel = New System.Windows.Forms.Label()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        SurveyNameLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        NetworkLabel = New System.Windows.Forms.Label()
        ParkLabel = New System.Windows.Forms.Label()
        SeasonLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        AreaSurveyed_miLabel = New System.Windows.Forms.Label()
        AverageSearchEffortLabel = New System.Windows.Forms.Label()
        MethodologyLabel = New System.Windows.Forms.Label()
        ProtocolVersionLabel = New System.Windows.Forms.Label()
        ProtocolReferenceCodeLabel = New System.Windows.Forms.Label()
        PersonnelLabel = New System.Windows.Forms.Label()
        ReportReferenceCodeLabel = New System.Windows.Forms.Label()
        ReportLinkLabel = New System.Windows.Forms.Label()
        DeliverablesDatasetReferenceCodeLabel = New System.Windows.Forms.Label()
        DataSourceLabel = New System.Windows.Forms.Label()
        DataResourcesDirectoryLabel = New System.Windows.Forms.Label()
        AbstractLabel = New System.Windows.Forms.Label()
        SummaryLabel = New System.Windows.Forms.Label()
        DatasetProcessingStepsLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_DensityEstimatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_PopulationEstimatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_ResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.SurveysInventoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SurveyDetailsXtraTabPage.SuspendLayout()
        CType(Me.FKGSPEGSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SurveyDetailsPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MooseDataSet
        '
        Me.MooseDataSet.DataSetName = "MooseDataSet"
        Me.MooseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSPE_SurveysBindingSource
        '
        Me.GSPE_SurveysBindingSource.DataMember = "GSPE_Surveys"
        Me.GSPE_SurveysBindingSource.DataSource = Me.MooseDataSet
        '
        'GSPE_SurveysTableAdapter
        '
        Me.GSPE_SurveysTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GSPE_DensityEstimatesTableAdapter = Me.GSPE_DensityEstimatesTableAdapter
        Me.TableAdapterManager.GSPE_PopulationEstimatesTableAdapter = Me.GSPE_PopulationEstimatesTableAdapter
        Me.TableAdapterManager.GSPE_ResultsTableAdapter = Me.GSPE_ResultsTableAdapter
        Me.TableAdapterManager.GSPE_SurveysTableAdapter = Me.GSPE_SurveysTableAdapter
        Me.TableAdapterManager.GSPETableAdapter = Me.GSPETableAdapter
        Me.TableAdapterManager.UpdateOrder = Moose_3.MooseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GSPE_DensityEstimatesTableAdapter
        '
        Me.GSPE_DensityEstimatesTableAdapter.ClearBeforeFill = True
        '
        'GSPE_PopulationEstimatesTableAdapter
        '
        Me.GSPE_PopulationEstimatesTableAdapter.ClearBeforeFill = True
        '
        'GSPE_ResultsTableAdapter
        '
        Me.GSPE_ResultsTableAdapter.ClearBeforeFill = True
        '
        'GSPETableAdapter
        '
        Me.GSPETableAdapter.ClearBeforeFill = True
        '
        'GSPE_DensityEstimatesBindingSource
        '
        Me.GSPE_DensityEstimatesBindingSource.DataMember = "FK_GSPE_DensityEstimates_GSPE_Surveys"
        Me.GSPE_DensityEstimatesBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPE_PopulationEstimatesBindingSource
        '
        Me.GSPE_PopulationEstimatesBindingSource.DataMember = "FK_GSPE_PopulationEstimates_GSPE_Surveys"
        Me.GSPE_PopulationEstimatesBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPE_ResultsBindingSource
        '
        Me.GSPE_ResultsBindingSource.DataMember = "FK_GSPE_Ratios_GSPE_Surveys"
        Me.GSPE_ResultsBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPEBindingSource
        '
        Me.GSPEBindingSource.DataMember = "FK_GSPE_GSPE_Surveys"
        Me.GSPEBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'MainDockManager
        '
        Me.MainDockManager.Form = Me
        Me.MainDockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.MainDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("6e983490-84fc-475e-827b-7f8ed749de2f")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(230, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(230, 1061)
        Me.DockPanel1.Text = "Moose surveys inventory"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.SurveysInventoryGridControl)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(223, 1032)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'SurveysInventoryGridControl
        '
        Me.SurveysInventoryGridControl.DataSource = Me.GSPE_SurveysBindingSource
        Me.SurveysInventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SurveysInventoryGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SurveysInventoryGridControl.MainView = Me.GridView1
        Me.SurveysInventoryGridControl.Name = "SurveysInventoryGridControl"
        Me.SurveysInventoryGridControl.Size = New System.Drawing.Size(223, 1032)
        Me.SurveysInventoryGridControl.TabIndex = 0
        Me.SurveysInventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSurveyName, Me.colYear, Me.colNetwork, Me.colPark, Me.colSeason, Me.colMethodology})
        Me.GridView1.GridControl = Me.SurveysInventoryGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colSurveyName
        '
        Me.colSurveyName.FieldName = "SurveyName"
        Me.colSurveyName.Name = "colSurveyName"
        Me.colSurveyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SurveyName", "Count: {0}")})
        Me.colSurveyName.Visible = True
        Me.colSurveyName.VisibleIndex = 0
        Me.colSurveyName.Width = 197
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 1
        Me.colYear.Width = 45
        '
        'colNetwork
        '
        Me.colNetwork.FieldName = "Network"
        Me.colNetwork.Name = "colNetwork"
        Me.colNetwork.Visible = True
        Me.colNetwork.VisibleIndex = 2
        Me.colNetwork.Width = 63
        '
        'colPark
        '
        Me.colPark.FieldName = "Park"
        Me.colPark.Name = "colPark"
        Me.colPark.Visible = True
        Me.colPark.VisibleIndex = 3
        Me.colPark.Width = 44
        '
        'colSeason
        '
        Me.colSeason.FieldName = "Season"
        Me.colSeason.Name = "colSeason"
        Me.colSeason.Visible = True
        Me.colSeason.VisibleIndex = 4
        Me.colSeason.Width = 58
        '
        'colMethodology
        '
        Me.colMethodology.FieldName = "Methodology"
        Me.colMethodology.Name = "colMethodology"
        Me.colMethodology.Visible = True
        Me.colMethodology.VisibleIndex = 5
        Me.colMethodology.Width = 125
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(230, 40)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.SurveyDetailsXtraTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1354, 1021)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.SurveyDetailsXtraTabPage, Me.XtraTabPage2})
        '
        'SurveyDetailsXtraTabPage
        '
        Me.SurveyDetailsXtraTabPage.Controls.Add(Me.SurveyDetailsPanel)
        Me.SurveyDetailsXtraTabPage.Name = "SurveyDetailsXtraTabPage"
        Me.SurveyDetailsXtraTabPage.Size = New System.Drawing.Size(1352, 996)
        Me.SurveyDetailsXtraTabPage.Text = "Survey details"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(298, 275)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'FKGSPEGSPESurveysBindingSource
        '
        Me.FKGSPEGSPESurveysBindingSource.DataMember = "FK_GSPE_GSPE_Surveys"
        Me.FKGSPEGSPESurveysBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'SurveyDetailsPanel
        '
        Me.SurveyDetailsPanel.Controls.Add(SurveyNameLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.SurveyNameTextBox)
        Me.SurveyDetailsPanel.Controls.Add(YearLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.YearTextBox)
        Me.SurveyDetailsPanel.Controls.Add(NetworkLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.NetworkTextBox)
        Me.SurveyDetailsPanel.Controls.Add(ParkLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.ParkTextBox)
        Me.SurveyDetailsPanel.Controls.Add(SeasonLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.SeasonTextBox)
        Me.SurveyDetailsPanel.Controls.Add(StartDateLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.StartDateDateTimePicker)
        Me.SurveyDetailsPanel.Controls.Add(EndDateLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.EndDateDateTimePicker)
        Me.SurveyDetailsPanel.Controls.Add(AreaSurveyed_miLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.AreaSurveyed_miTextBox)
        Me.SurveyDetailsPanel.Controls.Add(AverageSearchEffortLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.AverageSearchEffortTextBox)
        Me.SurveyDetailsPanel.Controls.Add(MethodologyLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.MethodologyTextBox)
        Me.SurveyDetailsPanel.Controls.Add(ProtocolVersionLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.ProtocolVersionTextBox)
        Me.SurveyDetailsPanel.Controls.Add(ProtocolReferenceCodeLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.ProtocolReferenceCodeTextBox)
        Me.SurveyDetailsPanel.Controls.Add(PersonnelLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.PersonnelTextBox)
        Me.SurveyDetailsPanel.Controls.Add(ReportReferenceCodeLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.ReportReferenceCodeTextBox)
        Me.SurveyDetailsPanel.Controls.Add(ReportLinkLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.ReportLinkTextBox)
        Me.SurveyDetailsPanel.Controls.Add(DeliverablesDatasetReferenceCodeLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.DeliverablesDatasetReferenceCodeTextBox)
        Me.SurveyDetailsPanel.Controls.Add(DataSourceLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.DataSourceTextBox)
        Me.SurveyDetailsPanel.Controls.Add(DataResourcesDirectoryLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.DataResourcesDirectoryTextBox)
        Me.SurveyDetailsPanel.Controls.Add(AbstractLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.AbstractTextBox)
        Me.SurveyDetailsPanel.Controls.Add(SummaryLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.SummaryTextBox)
        Me.SurveyDetailsPanel.Controls.Add(DatasetProcessingStepsLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.DatasetProcessingStepsTextBox)
        Me.SurveyDetailsPanel.Controls.Add(CommentsLabel)
        Me.SurveyDetailsPanel.Controls.Add(Me.CommentsTextBox)
        Me.SurveyDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SurveyDetailsPanel.Location = New System.Drawing.Point(0, 0)
        Me.SurveyDetailsPanel.Name = "SurveyDetailsPanel"
        Me.SurveyDetailsPanel.Size = New System.Drawing.Size(1352, 996)
        Me.SurveyDetailsPanel.TabIndex = 0
        '
        'SurveyNameLabel
        '
        SurveyNameLabel.AutoSize = True
        SurveyNameLabel.Location = New System.Drawing.Point(25, 140)
        SurveyNameLabel.Name = "SurveyNameLabel"
        SurveyNameLabel.Size = New System.Drawing.Size(75, 13)
        SurveyNameLabel.TabIndex = 0
        SurveyNameLabel.Text = "Survey Name:"
        '
        'SurveyNameTextBox
        '
        Me.SurveyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "SurveyName", True))
        Me.SurveyNameTextBox.Location = New System.Drawing.Point(222, 137)
        Me.SurveyNameTextBox.Name = "SurveyNameTextBox"
        Me.SurveyNameTextBox.Size = New System.Drawing.Size(86, 21)
        Me.SurveyNameTextBox.TabIndex = 1
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.Location = New System.Drawing.Point(25, 167)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(33, 13)
        YearLabel.TabIndex = 2
        YearLabel.Text = "Year:"
        '
        'YearTextBox
        '
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(222, 164)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(86, 21)
        Me.YearTextBox.TabIndex = 3
        '
        'NetworkLabel
        '
        NetworkLabel.AutoSize = True
        NetworkLabel.Location = New System.Drawing.Point(25, 194)
        NetworkLabel.Name = "NetworkLabel"
        NetworkLabel.Size = New System.Drawing.Size(51, 13)
        NetworkLabel.TabIndex = 4
        NetworkLabel.Text = "Network:"
        '
        'NetworkTextBox
        '
        Me.NetworkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Network", True))
        Me.NetworkTextBox.Location = New System.Drawing.Point(222, 191)
        Me.NetworkTextBox.Name = "NetworkTextBox"
        Me.NetworkTextBox.Size = New System.Drawing.Size(86, 21)
        Me.NetworkTextBox.TabIndex = 5
        '
        'ParkLabel
        '
        ParkLabel.AutoSize = True
        ParkLabel.Location = New System.Drawing.Point(25, 221)
        ParkLabel.Name = "ParkLabel"
        ParkLabel.Size = New System.Drawing.Size(32, 13)
        ParkLabel.TabIndex = 6
        ParkLabel.Text = "Park:"
        '
        'ParkTextBox
        '
        Me.ParkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Park", True))
        Me.ParkTextBox.Location = New System.Drawing.Point(222, 218)
        Me.ParkTextBox.Name = "ParkTextBox"
        Me.ParkTextBox.Size = New System.Drawing.Size(86, 21)
        Me.ParkTextBox.TabIndex = 7
        '
        'SeasonLabel
        '
        SeasonLabel.AutoSize = True
        SeasonLabel.Location = New System.Drawing.Point(25, 248)
        SeasonLabel.Name = "SeasonLabel"
        SeasonLabel.Size = New System.Drawing.Size(46, 13)
        SeasonLabel.TabIndex = 8
        SeasonLabel.Text = "Season:"
        '
        'SeasonTextBox
        '
        Me.SeasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Season", True))
        Me.SeasonTextBox.Location = New System.Drawing.Point(222, 245)
        Me.SeasonTextBox.Name = "SeasonTextBox"
        Me.SeasonTextBox.Size = New System.Drawing.Size(86, 21)
        Me.SeasonTextBox.TabIndex = 9
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(25, 276)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(61, 13)
        StartDateLabel.TabIndex = 10
        StartDateLabel.Text = "Start Date:"
        '
        'StartDateDateTimePicker
        '
        Me.StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GSPE_SurveysBindingSource, "StartDate", True))
        Me.StartDateDateTimePicker.Location = New System.Drawing.Point(222, 272)
        Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
        Me.StartDateDateTimePicker.Size = New System.Drawing.Size(86, 21)
        Me.StartDateDateTimePicker.TabIndex = 11
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Location = New System.Drawing.Point(25, 303)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(55, 13)
        EndDateLabel.TabIndex = 12
        EndDateLabel.Text = "End Date:"
        '
        'EndDateDateTimePicker
        '
        Me.EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GSPE_SurveysBindingSource, "EndDate", True))
        Me.EndDateDateTimePicker.Location = New System.Drawing.Point(222, 299)
        Me.EndDateDateTimePicker.Name = "EndDateDateTimePicker"
        Me.EndDateDateTimePicker.Size = New System.Drawing.Size(86, 21)
        Me.EndDateDateTimePicker.TabIndex = 13
        '
        'AreaSurveyed_miLabel
        '
        AreaSurveyed_miLabel.AutoSize = True
        AreaSurveyed_miLabel.Location = New System.Drawing.Point(25, 329)
        AreaSurveyed_miLabel.Name = "AreaSurveyed_miLabel"
        AreaSurveyed_miLabel.Size = New System.Drawing.Size(96, 13)
        AreaSurveyed_miLabel.TabIndex = 14
        AreaSurveyed_miLabel.Text = "Area Surveyed mi:"
        '
        'AreaSurveyed_miTextBox
        '
        Me.AreaSurveyed_miTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "AreaSurveyed_mi", True))
        Me.AreaSurveyed_miTextBox.Location = New System.Drawing.Point(222, 326)
        Me.AreaSurveyed_miTextBox.Name = "AreaSurveyed_miTextBox"
        Me.AreaSurveyed_miTextBox.Size = New System.Drawing.Size(86, 21)
        Me.AreaSurveyed_miTextBox.TabIndex = 15
        '
        'AverageSearchEffortLabel
        '
        AverageSearchEffortLabel.AutoSize = True
        AverageSearchEffortLabel.Location = New System.Drawing.Point(25, 356)
        AverageSearchEffortLabel.Name = "AverageSearchEffortLabel"
        AverageSearchEffortLabel.Size = New System.Drawing.Size(119, 13)
        AverageSearchEffortLabel.TabIndex = 16
        AverageSearchEffortLabel.Text = "Average Search Effort:"
        '
        'AverageSearchEffortTextBox
        '
        Me.AverageSearchEffortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "AverageSearchEffort", True))
        Me.AverageSearchEffortTextBox.Location = New System.Drawing.Point(222, 353)
        Me.AverageSearchEffortTextBox.Name = "AverageSearchEffortTextBox"
        Me.AverageSearchEffortTextBox.Size = New System.Drawing.Size(86, 21)
        Me.AverageSearchEffortTextBox.TabIndex = 17
        '
        'MethodologyLabel
        '
        MethodologyLabel.AutoSize = True
        MethodologyLabel.Location = New System.Drawing.Point(25, 383)
        MethodologyLabel.Name = "MethodologyLabel"
        MethodologyLabel.Size = New System.Drawing.Size(73, 13)
        MethodologyLabel.TabIndex = 18
        MethodologyLabel.Text = "Methodology:"
        '
        'MethodologyTextBox
        '
        Me.MethodologyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Methodology", True))
        Me.MethodologyTextBox.Location = New System.Drawing.Point(222, 380)
        Me.MethodologyTextBox.Name = "MethodologyTextBox"
        Me.MethodologyTextBox.Size = New System.Drawing.Size(86, 21)
        Me.MethodologyTextBox.TabIndex = 19
        '
        'ProtocolVersionLabel
        '
        ProtocolVersionLabel.AutoSize = True
        ProtocolVersionLabel.Location = New System.Drawing.Point(25, 410)
        ProtocolVersionLabel.Name = "ProtocolVersionLabel"
        ProtocolVersionLabel.Size = New System.Drawing.Size(88, 13)
        ProtocolVersionLabel.TabIndex = 20
        ProtocolVersionLabel.Text = "Protocol Version:"
        '
        'ProtocolVersionTextBox
        '
        Me.ProtocolVersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "ProtocolVersion", True))
        Me.ProtocolVersionTextBox.Location = New System.Drawing.Point(222, 407)
        Me.ProtocolVersionTextBox.Name = "ProtocolVersionTextBox"
        Me.ProtocolVersionTextBox.Size = New System.Drawing.Size(86, 21)
        Me.ProtocolVersionTextBox.TabIndex = 21
        '
        'ProtocolReferenceCodeLabel
        '
        ProtocolReferenceCodeLabel.AutoSize = True
        ProtocolReferenceCodeLabel.Location = New System.Drawing.Point(25, 437)
        ProtocolReferenceCodeLabel.Name = "ProtocolReferenceCodeLabel"
        ProtocolReferenceCodeLabel.Size = New System.Drawing.Size(131, 13)
        ProtocolReferenceCodeLabel.TabIndex = 22
        ProtocolReferenceCodeLabel.Text = "Protocol Reference Code:"
        '
        'ProtocolReferenceCodeTextBox
        '
        Me.ProtocolReferenceCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "ProtocolReferenceCode", True))
        Me.ProtocolReferenceCodeTextBox.Location = New System.Drawing.Point(222, 434)
        Me.ProtocolReferenceCodeTextBox.Name = "ProtocolReferenceCodeTextBox"
        Me.ProtocolReferenceCodeTextBox.Size = New System.Drawing.Size(86, 21)
        Me.ProtocolReferenceCodeTextBox.TabIndex = 23
        '
        'PersonnelLabel
        '
        PersonnelLabel.AutoSize = True
        PersonnelLabel.Location = New System.Drawing.Point(25, 464)
        PersonnelLabel.Name = "PersonnelLabel"
        PersonnelLabel.Size = New System.Drawing.Size(58, 13)
        PersonnelLabel.TabIndex = 24
        PersonnelLabel.Text = "Personnel:"
        '
        'PersonnelTextBox
        '
        Me.PersonnelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Personnel", True))
        Me.PersonnelTextBox.Location = New System.Drawing.Point(222, 461)
        Me.PersonnelTextBox.Name = "PersonnelTextBox"
        Me.PersonnelTextBox.Size = New System.Drawing.Size(86, 21)
        Me.PersonnelTextBox.TabIndex = 25
        '
        'ReportReferenceCodeLabel
        '
        ReportReferenceCodeLabel.AutoSize = True
        ReportReferenceCodeLabel.Location = New System.Drawing.Point(25, 491)
        ReportReferenceCodeLabel.Name = "ReportReferenceCodeLabel"
        ReportReferenceCodeLabel.Size = New System.Drawing.Size(125, 13)
        ReportReferenceCodeLabel.TabIndex = 26
        ReportReferenceCodeLabel.Text = "Report Reference Code:"
        '
        'ReportReferenceCodeTextBox
        '
        Me.ReportReferenceCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "ReportReferenceCode", True))
        Me.ReportReferenceCodeTextBox.Location = New System.Drawing.Point(222, 488)
        Me.ReportReferenceCodeTextBox.Name = "ReportReferenceCodeTextBox"
        Me.ReportReferenceCodeTextBox.Size = New System.Drawing.Size(86, 21)
        Me.ReportReferenceCodeTextBox.TabIndex = 27
        '
        'ReportLinkLabel
        '
        ReportLinkLabel.AutoSize = True
        ReportLinkLabel.Location = New System.Drawing.Point(25, 518)
        ReportLinkLabel.Name = "ReportLinkLabel"
        ReportLinkLabel.Size = New System.Drawing.Size(65, 13)
        ReportLinkLabel.TabIndex = 28
        ReportLinkLabel.Text = "Report Link:"
        '
        'ReportLinkTextBox
        '
        Me.ReportLinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "ReportLink", True))
        Me.ReportLinkTextBox.Location = New System.Drawing.Point(222, 515)
        Me.ReportLinkTextBox.Name = "ReportLinkTextBox"
        Me.ReportLinkTextBox.Size = New System.Drawing.Size(86, 21)
        Me.ReportLinkTextBox.TabIndex = 29
        '
        'DeliverablesDatasetReferenceCodeLabel
        '
        DeliverablesDatasetReferenceCodeLabel.AutoSize = True
        DeliverablesDatasetReferenceCodeLabel.Location = New System.Drawing.Point(25, 545)
        DeliverablesDatasetReferenceCodeLabel.Name = "DeliverablesDatasetReferenceCodeLabel"
        DeliverablesDatasetReferenceCodeLabel.Size = New System.Drawing.Size(191, 13)
        DeliverablesDatasetReferenceCodeLabel.TabIndex = 30
        DeliverablesDatasetReferenceCodeLabel.Text = "Deliverables Dataset Reference Code:"
        '
        'DeliverablesDatasetReferenceCodeTextBox
        '
        Me.DeliverablesDatasetReferenceCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "DeliverablesDatasetReferenceCode", True))
        Me.DeliverablesDatasetReferenceCodeTextBox.Location = New System.Drawing.Point(222, 542)
        Me.DeliverablesDatasetReferenceCodeTextBox.Name = "DeliverablesDatasetReferenceCodeTextBox"
        Me.DeliverablesDatasetReferenceCodeTextBox.Size = New System.Drawing.Size(86, 21)
        Me.DeliverablesDatasetReferenceCodeTextBox.TabIndex = 31
        '
        'DataSourceLabel
        '
        DataSourceLabel.AutoSize = True
        DataSourceLabel.Location = New System.Drawing.Point(25, 572)
        DataSourceLabel.Name = "DataSourceLabel"
        DataSourceLabel.Size = New System.Drawing.Size(70, 13)
        DataSourceLabel.TabIndex = 32
        DataSourceLabel.Text = "Data Source:"
        '
        'DataSourceTextBox
        '
        Me.DataSourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "DataSource", True))
        Me.DataSourceTextBox.Location = New System.Drawing.Point(222, 569)
        Me.DataSourceTextBox.Name = "DataSourceTextBox"
        Me.DataSourceTextBox.Size = New System.Drawing.Size(86, 21)
        Me.DataSourceTextBox.TabIndex = 33
        '
        'DataResourcesDirectoryLabel
        '
        DataResourcesDirectoryLabel.AutoSize = True
        DataResourcesDirectoryLabel.Location = New System.Drawing.Point(25, 599)
        DataResourcesDirectoryLabel.Name = "DataResourcesDirectoryLabel"
        DataResourcesDirectoryLabel.Size = New System.Drawing.Size(134, 13)
        DataResourcesDirectoryLabel.TabIndex = 34
        DataResourcesDirectoryLabel.Text = "Data Resources Directory:"
        '
        'DataResourcesDirectoryTextBox
        '
        Me.DataResourcesDirectoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "DataResourcesDirectory", True))
        Me.DataResourcesDirectoryTextBox.Location = New System.Drawing.Point(222, 596)
        Me.DataResourcesDirectoryTextBox.Name = "DataResourcesDirectoryTextBox"
        Me.DataResourcesDirectoryTextBox.Size = New System.Drawing.Size(86, 21)
        Me.DataResourcesDirectoryTextBox.TabIndex = 35
        '
        'AbstractLabel
        '
        AbstractLabel.AutoSize = True
        AbstractLabel.Location = New System.Drawing.Point(669, 91)
        AbstractLabel.Name = "AbstractLabel"
        AbstractLabel.Size = New System.Drawing.Size(52, 13)
        AbstractLabel.TabIndex = 36
        AbstractLabel.Text = "Abstract:"
        '
        'AbstractTextBox
        '
        Me.AbstractTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Abstract", True))
        Me.AbstractTextBox.Location = New System.Drawing.Point(866, 88)
        Me.AbstractTextBox.Name = "AbstractTextBox"
        Me.AbstractTextBox.Size = New System.Drawing.Size(86, 21)
        Me.AbstractTextBox.TabIndex = 37
        '
        'SummaryLabel
        '
        SummaryLabel.AutoSize = True
        SummaryLabel.Location = New System.Drawing.Point(669, 118)
        SummaryLabel.Name = "SummaryLabel"
        SummaryLabel.Size = New System.Drawing.Size(55, 13)
        SummaryLabel.TabIndex = 38
        SummaryLabel.Text = "Summary:"
        '
        'SummaryTextBox
        '
        Me.SummaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Summary", True))
        Me.SummaryTextBox.Location = New System.Drawing.Point(866, 115)
        Me.SummaryTextBox.Name = "SummaryTextBox"
        Me.SummaryTextBox.Size = New System.Drawing.Size(86, 21)
        Me.SummaryTextBox.TabIndex = 39
        '
        'DatasetProcessingStepsLabel
        '
        DatasetProcessingStepsLabel.AutoSize = True
        DatasetProcessingStepsLabel.Location = New System.Drawing.Point(669, 145)
        DatasetProcessingStepsLabel.Name = "DatasetProcessingStepsLabel"
        DatasetProcessingStepsLabel.Size = New System.Drawing.Size(133, 13)
        DatasetProcessingStepsLabel.TabIndex = 40
        DatasetProcessingStepsLabel.Text = "Dataset Processing Steps:"
        '
        'DatasetProcessingStepsTextBox
        '
        Me.DatasetProcessingStepsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "DatasetProcessingSteps", True))
        Me.DatasetProcessingStepsTextBox.Location = New System.Drawing.Point(866, 142)
        Me.DatasetProcessingStepsTextBox.Name = "DatasetProcessingStepsTextBox"
        Me.DatasetProcessingStepsTextBox.Size = New System.Drawing.Size(86, 21)
        Me.DatasetProcessingStepsTextBox.TabIndex = 41
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(669, 59)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(61, 13)
        CommentsLabel.TabIndex = 42
        CommentsLabel.Text = "Comments:"
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(866, 56)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(86, 21)
        Me.CommentsTextBox.TabIndex = 43
        '
        'SurveyNameHeaderLabel
        '
        Me.SurveyNameHeaderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SurveyNameHeaderLabel.AutoEllipsis = True
        Me.SurveyNameHeaderLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GSPE_SurveysBindingSource, "SurveyName", True))
        Me.SurveyNameHeaderLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurveyNameHeaderLabel.Location = New System.Drawing.Point(6, 9)
        Me.SurveyNameHeaderLabel.Name = "SurveyNameHeaderLabel"
        Me.SurveyNameHeaderLabel.Size = New System.Drawing.Size(1322, 34)
        Me.SurveyNameHeaderLabel.TabIndex = 44
        Me.SurveyNameHeaderLabel.Text = "Label1"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.SurveyNameHeaderLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(230, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1354, 40)
        Me.HeaderPanel.TabIndex = 45
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 1061)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.DockPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Moose Monitoring Database Application"
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_DensityEstimatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_PopulationEstimatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_ResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.SurveysInventoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.SurveyDetailsXtraTabPage.ResumeLayout(False)
        CType(Me.FKGSPEGSPESurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SurveyDetailsPanel.ResumeLayout(False)
        Me.SurveyDetailsPanel.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MooseDataSet As MooseDataSet
    Friend WithEvents GSPE_SurveysBindingSource As BindingSource
    Friend WithEvents GSPE_SurveysTableAdapter As MooseDataSetTableAdapters.GSPE_SurveysTableAdapter
    Friend WithEvents TableAdapterManager As MooseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GSPE_DensityEstimatesTableAdapter As MooseDataSetTableAdapters.GSPE_DensityEstimatesTableAdapter
    Friend WithEvents GSPE_DensityEstimatesBindingSource As BindingSource
    Friend WithEvents GSPE_PopulationEstimatesTableAdapter As MooseDataSetTableAdapters.GSPE_PopulationEstimatesTableAdapter
    Friend WithEvents GSPE_PopulationEstimatesBindingSource As BindingSource
    Friend WithEvents GSPE_ResultsTableAdapter As MooseDataSetTableAdapters.GSPE_ResultsTableAdapter
    Friend WithEvents GSPE_ResultsBindingSource As BindingSource
    Friend WithEvents GSPETableAdapter As MooseDataSetTableAdapters.GSPETableAdapter
    Friend WithEvents GSPEBindingSource As BindingSource
    Friend WithEvents MainDockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents SurveysInventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSurveyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNetwork As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMethodology As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SurveyDetailsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SurveyDetailsPanel As Panel
    Friend WithEvents SurveyNameTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents NetworkTextBox As TextBox
    Friend WithEvents ParkTextBox As TextBox
    Friend WithEvents SeasonTextBox As TextBox
    Friend WithEvents StartDateDateTimePicker As DateTimePicker
    Friend WithEvents EndDateDateTimePicker As DateTimePicker
    Friend WithEvents AreaSurveyed_miTextBox As TextBox
    Friend WithEvents AverageSearchEffortTextBox As TextBox
    Friend WithEvents MethodologyTextBox As TextBox
    Friend WithEvents ProtocolVersionTextBox As TextBox
    Friend WithEvents ProtocolReferenceCodeTextBox As TextBox
    Friend WithEvents PersonnelTextBox As TextBox
    Friend WithEvents ReportReferenceCodeTextBox As TextBox
    Friend WithEvents ReportLinkTextBox As TextBox
    Friend WithEvents DeliverablesDatasetReferenceCodeTextBox As TextBox
    Friend WithEvents DataSourceTextBox As TextBox
    Friend WithEvents DataResourcesDirectoryTextBox As TextBox
    Friend WithEvents AbstractTextBox As TextBox
    Friend WithEvents SummaryTextBox As TextBox
    Friend WithEvents DatasetProcessingStepsTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents SurveyNameHeaderLabel As Label
    Friend WithEvents FKGSPEGSPESurveysBindingSource As BindingSource
End Class
