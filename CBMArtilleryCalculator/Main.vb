Public Class FrmArtyCalculator
    'Made by [CBM]Merskies
    '11/17/2017
    Public Min, Max As Integer
    Public NameofArty As String
    Public Class Artillery
        Public Property Name As String
        Public Property MinRange As Integer
        Public Property MaxRange As Integer
        Public Sub New(Name As String, Min As Integer, Max As Integer)
            Me.Name = Name
            Me.MinRange = Min
            Me.MaxRange = Max
        End Sub
    End Class
    Private ArtilleryMap As New Dictionary(Of RadioButton, Artillery)
    Private Sub ArtyCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArtilleryMap.Add(rBtnMortar, New Artillery("Mortar", 45, 65))
        ArtilleryMap.Add(rBtnHowitzer, New Artillery("Howitzer", 75, 150))
        ArtilleryMap.Add(rBtnFieldArtillery, New Artillery("Field Artillery", 75, 150))
        ArtilleryMap.Add(rBtnGunBoat, New Artillery("Gun Boat", 50, 100))
        ArtilleryMap.Add(rBtnTank, New Artillery("Tank", 1, 40))
    End Sub
    Private Sub Artillery_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnMortar.CheckedChanged, rBtnHowitzer.CheckedChanged, rBtnFieldArtillery.CheckedChanged, rBtnGunBoat.CheckedChanged, rBtnTank.CheckedChanged

        Dim radio As RadioButton = TryCast(sender, RadioButton)
        If radio Is Nothing OrElse Not ArtilleryMap.ContainsKey(radio) Then Return

        Dim art As Artillery = ArtilleryMap(radio)

        Me.Min = art.MinRange
        Me.Max = art.MaxRange
        Me.NameofArty = art.Name
        txtMinimum.Text = "Minimum Distance: " & art.MinRange
        txtMaximum.Text = "Maximum Distance: " & art.MaxRange
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbDistancetoTarget.CheckedChanged, cbArtyAzimuth.CheckedChanged, cbDistancetoArty.CheckedChanged, cbTargetAzimuth.CheckedChanged
        txtDistancetoTarget.Enabled = cbDistancetoTarget.Checked = False
        txtDistancetoArty.Enabled = cbDistancetoArty.Checked = False
        txtTargetAzimuth.Enabled = cbTargetAzimuth.Checked = False
        txtArtyAzimuth.Enabled = cbArtyAzimuth.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim DistancetoTarget, TargetAzimuth, DistancetoArty, ArtyAzimuth As Double
        Dim AngleofSpotter, AngleofSpotterinRads, DistancefromArtytoTarget, SinofRads, DegreeofArtyinRads, DegreeofArtyinDegrees, RoundedDegree, RawAzimuth, FinalAzimuth As Double
        Dim OrderDistance, OrderAzimuth As Double
        'Input
        Try
            DistancetoTarget = txtDistancetoTarget.Text
            TargetAzimuth = txtTargetAzimuth.Text
            DistancetoArty = txtDistancetoArty.Text
            ArtyAzimuth = txtArtyAzimuth.Text

            'Angle of Spotter
            If (TargetAzimuth > ArtyAzimuth) Then
                AngleofSpotter = TargetAzimuth - ArtyAzimuth
            Else
                AngleofSpotter = ArtyAzimuth - TargetAzimuth
            End If
            'Angle of Spotter in Rads
            AngleofSpotterinRads = AngleofSpotter * Math.PI / 180
            'Distance from Arty to Target
            DistancefromArtytoTarget = Math.Sqrt((DistancetoTarget ^ 2) + (DistancetoArty ^ 2) - (2 * DistancetoTarget * DistancetoArty * Math.Cos(AngleofSpotterinRads)))
            'Sin of Rads
            SinofRads = (DistancetoTarget * Math.Sin(AngleofSpotterinRads)) / DistancefromArtytoTarget
            'Degree of Arty in Rads
            DegreeofArtyinRads = Math.Asin(SinofRads)
            'Degree of Arty in Degrees
            DegreeofArtyinDegrees = DegreeofArtyinRads * (180 / Math.PI)
            'Rounded Degrees
            RoundedDegree = Math.Round(DegreeofArtyinDegrees, 0)
            'Raw Azimuth
            If TargetAzimuth > ArtyAzimuth Then
                RawAzimuth = (ArtyAzimuth + 180) - RoundedDegree
            Else
                RawAzimuth = (ArtyAzimuth + 180) + RoundedDegree
            End If
            'Final Azimuth
            If RawAzimuth > 360 Then
                FinalAzimuth = RawAzimuth - 360
            Else
                FinalAzimuth = RawAzimuth
            End If
            'Variables for Output
            OrderDistance = Math.Round(DistancefromArtytoTarget)
            OrderAzimuth = FinalAzimuth
            'Output
            If (OrderDistance >= Min And OrderDistance <= Max) Then
                txtOutput.Text = "Order Distance " & OrderDistance & ", Azimuth " & OrderAzimuth
            ElseIf (OrderDistance < Min) Then
                txtOutput.Text = "Distance is " & Math.Abs(Min - OrderDistance) & "(M) too short for the " & NameofArty & "!"
            Else txtOutput.Text = "Distance is " & Math.Abs(Max - OrderDistance) & "(M) too far for the " & NameofArty & "!"
            End If
        Catch
            txtOutput.Text = "Not Enough Data!"
        End Try
    End Sub
End Class
