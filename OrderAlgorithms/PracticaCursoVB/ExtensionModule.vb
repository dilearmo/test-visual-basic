Imports System.Runtime.CompilerServices
Module ExtensionModule

    <Extension()>
    Public Function Copy(Of T As {Class, New})(obj As T)
        If obj Is Nothing Then Return Nothing

        Dim copiedObj As New T
        Dim properties = obj.GetType().GetProperties()

        For Each prop In properties.Where(Function(p) p.CanRead AndAlso p.CanWrite)
            prop.SetValue(copiedObj, prop.GetValue(obj))
        Next

        Return copiedObj
    End Function

    <Extension()>
    Public Function ToTable(list As ICollection) As DataTable
        If list IsNot Nothing Then
            Dim table As New DataTable
            If list.Count > 0 AndAlso Not list(0).GetType().IsPrimitive() Then
                Dim listObjType = list.GetType().GetElementType()
                For Each typeProp In listObjType.GetProperties.Where(Function(x) x.CanRead AndAlso x.CanWrite)
                    table.Columns.Add(New DataColumn With {.ColumnName = typeProp.Name, .DataType = typeProp.GetType()})
                Next

                For Each element In list
                    Dim row As DataRow = table.NewRow()
                    Dim elementProps = element.GetType().GetProperties()
                    For Each p In elementProps.Where(Function(x) x.CanRead AndAlso x.CanWrite)
                        row(p.Name) = p.GetValue(element)
                        table.Rows.Add(row)
                    Next
                Next
            Else
                table.Columns.Add("Value", list.GetType().GetElementType())
                For Each value In list
                    Dim row As DataRow = table.NewRow()
                    row("Value") = value
                    table.Rows.Add(row)
                Next
            End If

            Return table
        End If
        Return Nothing
    End Function

End Module

