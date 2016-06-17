Public Class template
    Implements ITemplate
    Protected Friend Property UserControl As Control

    Public Sub New(Control As Control)
        UserControl = Control
    End Sub
    Public Sub InstantiateIn(container As Control) Implements ITemplate.InstantiateIn
        container.Controls.Add(UserControl)
    End Sub
End Class
