<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calis.aspx.cs" Inherits="TainEns.calis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server"
         OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
             OnRowEditing="GridView1_RowEditing"
              OnRowDeleting="GridView1_RowDeleting">
            <Columns>
            
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />                
                <asp:CommandField ShowSelectButton="True" />
                
            </Columns>
 
        </asp:GridView>
        <asp:Label ID="LabelMensaje" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server"
         OnSelectedIndexChanged="GridView2_SelectedIndexChanged"
             OnRowEditing="GridView2_RowEditing"
              OnRowDeleting="GridView2_RowDeleting">
            <Columns>
            
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />                
                <asp:CommandField ShowSelectButton="True" />
                
            </Columns>
 
        </asp:GridView>
        <br />
        
        <asp:Label ID="lblmsn" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>
    
    </form>
</body>
</html>
