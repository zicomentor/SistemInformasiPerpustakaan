Imports System.Data.OleDb
Imports System.Data

Module Login_Module

    Public OLECMD As OleDbCommand
    Public OLERDR As OleDbDataReader
    Public OLEDA As OleDbDataAdapter
    Public CNN As OleDbConnection
    Public DS As DataSet
    Public KSI As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=DB_User.mdb"
    Public x As Integer

End Module
