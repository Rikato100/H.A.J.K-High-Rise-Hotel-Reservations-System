Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class Class1
    Inherits Panel ' Inherit from Panel instead of Label

    Private _cornerRadius As Integer = 15
    Private _customBackColor As Color = Color.LightBlue

    Public Sub New()
        ' Enable double buffering to prevent flickering during resize
        Me.DoubleBuffered = True
        Me.AutoSize = False
    End Sub

    <Category("Appearance"), Description("The radius used to round the control's corners.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            If value > 0 Then
                _cornerRadius = value
                Me.Invalidate() ' Force the panel to redraw when changed
            End If
        End Set
    End Property

    <Category("Appearance")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CustomBackColor As Color
        Get
            Return _customBackColor
        End Get
        Set(value As Color)
            _customBackColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Clear background with the parent's backcolor to avoid ugly artifact edges
        If Me.Parent IsNot Nothing Then
            Using parentBrush As New SolidBrush(Me.Parent.BackColor)
                e.Graphics.FillRectangle(parentBrush, Me.ClientRectangle)
            End Using
        End If

        ' Set up smooth rendering options
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Create the rounded rectangle path
        Using path As GraphicsPath = GetRoundRectangle(Me.ClientRectangle, _cornerRadius)
            ' Fill the background of the panel inside the curves
            Using fillBrush As New SolidBrush(_customBackColor)
                e.Graphics.FillPath(fillBrush, path)
            End Using

            ' Draw a thin border line around the curves
            Using borderPen As New Pen(_customBackColor, 1.0F)
                e.Graphics.DrawPath(borderPen, path)
            End Using
        End Using

        ' Let the baseline Panel finish drawing any remaining elements
        MyBase.OnPaint(e)
    End Sub

    Private Function GetRoundRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Integer = radius * 2

        ' Handle cases where radius is too large for the current control dimensions
        If diameter > rect.Width Then diameter = rect.Width
        If diameter > rect.Height Then diameter = rect.Height

        Dim arcRect As New Rectangle(rect.X, rect.Y, diameter, diameter)

        ' Top-Left arc
        path.AddArc(arcRect, 180, 90)
        ' Top-Right arc
        arcRect.X = rect.Right - diameter
        path.AddArc(arcRect, 270, 90)
        ' Bottom-Right arc
        arcRect.Y = rect.Bottom - diameter
        path.AddArc(arcRect, 0, 90)
        ' Bottom-Left arc
        arcRect.X = rect.X
        path.AddArc(arcRect, 90, 90)

        path.CloseAllFigures()
        Return path
    End Function
End Class
