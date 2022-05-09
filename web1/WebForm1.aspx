<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="StyleSheet" href="StyleSheet1.css"/>
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
<link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
<script>
    $(function () {
        $("#textDate").datepicker(
            {
                changeMonth: true,
                changeYear: true,
                dateFormat: 'yy/mm/dd'
            });
    });
</script>

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
         <div align="center" background-color="red">
            <table>

                <tr>
                    <td colspan="2">
                        <asp:label ID="alert" runat="server">

                        </asp:label>
                    </td>
                </tr>
                 
                <tr>
                    <td>
                        Roll
                    </td>

                    <td>
                        <asp:TextBox ID="textBox3" runat="server"></asp:TextBox>
                    </td>


                    
                </tr>
          
                <tr>
                    <td>
                        Name
                    </td>

                    <td>
                        <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
                    </td>


                    
                </tr>
                 <tr>
                    <td>
                        Class
                    </td>
                     <td>
                       <asp:DropDownList ID="DropDownList2" runat="server">

                           <asp:listitem Text="Select Class" Value="Select Class" Selected="true"></asp:listitem>

                           <asp:listitem Text="I" Value="I" ></asp:listitem>
                           <asp:listitem Text="II" Value="II"></asp:listitem>
                           <asp:listitem Text="III" Value="III"></asp:listitem>
                            <asp:listitem Text="IV" Value="IV"> </asp:listitem>
                           <asp:listitem Text="V" Value="V"></asp:listitem>
                           <asp:listitem Text="VI" Value="VI"></asp:listitem>
                           <asp:listitem Text="VII" Value="VII"></asp:listitem>
                           <asp:listitem Text="VIII" Value="VIII"></asp:listitem>
                           <asp:listitem Text="IX" Value="IX"></asp:listitem>
                           <asp:listitem Text="X" Value="X"></asp:listitem>
                           <asp:listitem Text="XI" Value="XI"></asp:listitem>
                           <asp:listitem Text="XII" Value="XII">   </asp:listitem>

                           
                       </asp:DropDownList>
                         </td>

                    
                </tr>
                 <tr>
                    <td>
                        DoB
                    </td>
                     <td>
                         <asp:TextBox ID="textDate" runat="server" ></asp:TextBox>
                     </td>                  
                </tr>
                 <tr>
                    <td>
                        Gender
                    </td>
                     <td>
                       <asp:RadioButtonList ID="radioButton1" runat="server" >

                           <asp:listitem >Male</asp:listitem>
                           <asp:ListItem>Female</asp:ListItem>
                       </asp:RadioButtonList>
                    </td>
                </tr>

                 <tr>
                    <td>
                        State
                    </td>  
                     <td>
                       <asp:DropDownList ID="DropDownList1" runat="server">

                           <asp:listitem Text="Select State" Value="Select State" Selected="true"></asp:listitem>

                           <asp:listitem Text="Andhra Pradesh" Value="Andhra Pradesh" ></asp:listitem>
                           <asp:listitem Text="Bihar" Value=">Bihar"></asp:listitem>
                           <asp:listitem Text="Chhattisgarh" Value="Chhattisgarh"></asp:listitem>
                            <asp:listitem Text="Goa" Value="Goa"> </asp:listitem>
                           <asp:listitem Text="Gujarat" Value="Gujarat"></asp:listitem>
                           <asp:listitem Text="Haryana" Value="Haryana">Haryana</asp:listitem>
                           <asp:listitem Text="Hydrabad" Value="Hydabad"></asp:listitem>
                           <asp:listitem Text="Himachal Pradesh" Value="Himachal Pradesh"></asp:listitem>
                           <asp:listitem Text="Jharkhand" Value="Jharkhand"></asp:listitem>
                           <asp:listitem Text="Karnataka" Value="Karnataka"></asp:listitem>
                           <asp:listitem Text="Kerala" Value="Kerala"></asp:listitem>
                           <asp:listitem Text="Assam" Value="Assam">   </asp:listitem>
                           <asp:listitem Text="Madhya Pradesh" Value="Madhya Pradesh"></asp:listitem>
                           <asp:listitem Text="Maharashtra" Value="Maharashtra"></asp:listitem>
                           
                       </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                     
                    <td>
                        <asp:Button ID="submit" runat="server" onclick="Submit_Click" Text="Add"/>
                    </td>

                     <td>
                        <asp:Button ID="Button2" runat="server" onclick="Update_Click"  Text ="Update"/>
                    </td>

                     <td>
                        <asp:Button ID="Button3" runat="server" onclick="Reset_Click" Text="Reset"/>
                    </td>
                    <td>
                        <asp:Button ID="Button4" runat="server" OnClick="Select_Click" Text ="Select" />
                    </td>
                     
            </table>
        </div>

       
           
       
    </form>
</body>
</html>
