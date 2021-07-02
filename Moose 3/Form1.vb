Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class Form1
    Private Sub GSPE_SurveysBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        SaveDataset()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataset()

        SetUpGridControl(Me.SurveysInventoryGridControl)

    End Sub

    Private Sub LoadDataset()
        Try
            'Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE)
            Me.GSPE_ResultsTableAdapter.Fill(Me.MooseDataSet.GSPE_Results)
            Me.GSPE_PopulationEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_PopulationEstimates)
            Me.GSPE_DensityEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_DensityEstimates)
            Me.GSPE_SurveysTableAdapter.Fill(Me.MooseDataSet.GSPE_Surveys)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SaveDataset()
        Try
            Me.Validate()
            Me.GSPE_DensityEstimatesBindingSource.EndEdit()
            Me.GSPE_PopulationEstimatesBindingSource.EndEdit()
            Me.GSPE_ResultsBindingSource.EndEdit()
            Me.GSPEBindingSource.EndEdit()
            Me.GSPE_SurveysBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.MooseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub SetUpGridControl(GC As GridControl)
        GC.UseEmbeddedNavigator = True

        For Each MyGridView As GridView In GC.ViewCollection
            Debug.Print(MyGridView.Name)
            With MyGridView
                .OptionsBehavior.AllowAddRows = True
                .OptionsBehavior.AllowDeleteRows = True
                .BestFitColumns(False)
                .OptionsView.BestFitMode = GridBestFitMode.Fast
                .OptionsView.ColumnAutoWidth = False
                .OptionsView.ShowFooter = True
                .OptionsDetail.EnableMasterViewMode = False 'True to show sub-tables
            End With
        Next

        'Dim GV As GridView = TryCast(GC.MainView, GridView)
        'GV.OptionsBehavior.AllowAddRows = True
        'GV.OptionsBehavior.AllowDeleteRows = True
        'GV.BestFitColumns(False)
        'GV.OptionsView.BestFitMode = GridBestFitMode.Fast
        'GV.OptionsView.ColumnAutoWidth = False
        'GV.OptionsView.ShowFooter = True
        'GV.OptionsDetail.EnableMasterViewMode = False 'True to show sub-tables
    End Sub



End Class
