Imports System.IO

Public Class Menus
    Private MRUlist As New Queue(Of String)()

    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "javatpoint.com" ' Set the title of the form

        ' Create a menu bar
        Dim menuStrip As New MenuStrip()

        ' Create a "File" menu item
        Dim fileMenuItem As New ToolStripMenuItem("File")

        ' Add sub-items to the "File" menu
        Dim newMenuItem As New ToolStripMenuItem("New", Nothing, AddressOf RecentFile_click)
        Dim openMenuItem As New ToolStripMenuItem("Open", Nothing, AddressOf RecentFile_click)
        Dim saveMenuItem As New ToolStripMenuItem("Save", Nothing, AddressOf RecentFile_click)

        ' Add sub-items to the "File" menu
        fileMenuItem.DropDownItems.Add(newMenuItem)
        fileMenuItem.DropDownItems.Add(openMenuItem)
        fileMenuItem.DropDownItems.Add(saveMenuItem)

        ' Add the "File" menu to the menu bar
        menuStrip.Items.Add(fileMenuItem)

        ' Add the menu bar to the form
        Me.Controls.Add(menuStrip)
    End Sub

    Private Sub RecentFile_click(sender As Object, e As EventArgs)
        ' Handle the click event for recent files
        ' Implement your logic here
    End Sub

    Private Sub LoadRecentList()
        ' Load recent files from a file (e.g., Recent.txt)
        ' Implement your logic here
    End Sub
End Class

