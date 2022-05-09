<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridView.aspx.cs" Inherits="web1.gridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GridView</title>

    
    <script type="text/javascript">
        function ConfirmationBox(name) {
            var result = confirm('Are you sure you want to delete ' + name + ' Details');
            if (result) {
                return true;
            }
            else {
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Registration</h1>
            <hr />
            <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="false"   DataKeyNames="SNo" OnRowDataBound="gridView1_RowDataBound" >
                <columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="SNo" HeaderText="SNo" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="name" HeaderText="Name" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="class" HeaderText="Class" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="dob" HeaderText="Dob"  DataFormatString="{0:dd/MM/yyyy}"  />
                    <asp:BoundField ItemStyle-Width="150px" DataField="gender" HeaderText="Gender" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="state" HeaderText="State" />
                   <asp:TemplateField HeaderText="Update Row">
            <ItemTemplate>
                <asp:Button ID="Button1" Text="Update" runat="server" OnClick="OnGetDetails"   />
                
             </ItemTemplate>
            
        </asp:TemplateField>
                  
      <asp:TemplateField HeaderText="Delete Row">
        <ItemTemplate>
            <asp:Button ID="Button2" runat="server" Text="Delete"   OnClick="Button2_Click" />
        </ItemTemplate>
    </asp:TemplateField>
                       
                  
                </columns>
            </asp:GridView>
        </div>

     
    </form>
</body>
</html>
