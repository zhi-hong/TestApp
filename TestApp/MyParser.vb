Imports System.IO
Imports System.Text
Imports System.Xml

Public Structure Component
    Public Name As String
    Public CAS As String
    Public NBP As Double
    Public StdLiqDens As Double
    Public Mw As Double
    Public Type As String
End Structure

Public Structure ComponentList
    Public Name As String
    Public Components() As Component
End Structure

Public Structure PropPack
    Public Name As String
    Public Type As String
    Public ComponentList As ComponentList
End Structure


Public Class MyParser

    'members
    Public ComponentLists(0) As ComponentList

    Public Sub New()
        ' MessageBox.Show(String.Format("I instantiating myparser"))
    End Sub

    Public Sub ReadXML()



        Dim output As StringBuilder = New StringBuilder()
        Dim myelement As XmlElement
        Dim testbool As Boolean

        Dim subtree As XmlReader

        ' Create an XmlReader
        'Using reader As XmlReader = XmlReader.Create(New StringReader(xmlString))

        Dim reader As XmlReader = XmlReader.Create("XMLFile1.xml")


        'reader.WhitespaceHandling = WhitespaceHandling.None
        reader.ReadToFollowing("ComponentList")



        subtree = reader.ReadSubtree()

        _getcomponentlists(subtree, ComponentLists(0))

        testbool = reader.ReadToDescendant("ComponentList")
        'Do

        '    subtree = reader.ReadSubtree
        '    _getcomponentlists(subtree, ComponentLists(0))
        'Loop Until reader.ReadToFollowing("ReadToFollowing") = False

        'reader.Read()






        'Do Until reader.NodeType = XmlNodeType.Element And reader.Name = "CaseDescription"
        '    reader.Read()
        'Loop
        'Dim e As XElement = XElement.Load(reader)
        'Console.WriteLine(e)
        'End Using

        MessageBox.Show("dhfd")
    End Sub


    Private Sub _getcomponentlists(reader As XmlReader, complist As ComponentList)
        Dim comptree As String

        reader.ReadToDescendant("ComponentListName")
        reader.ReadToDescendant("Value")
        complist.Name = reader.ReadElementContentAsString()
        'Do
        '    reader.ReadToDescendant("Component")

        'Loop
    End Sub
End Class