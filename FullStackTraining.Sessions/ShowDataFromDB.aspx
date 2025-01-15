<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ShowDataFromDB.aspx.cs" Inherits="FullStackTraining.Sessions.ShowDataFromDB" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="container mt-3 bg">
            <h2>Top User</h2>

            <div class="mb-3 mt-3">
                <label>Name:</label>
                <asp:TextBox Enabled="false"  runat="server"  CssClass="form-control" ID="txtName"></asp:TextBox>
              
            </div>

            <div class="mb-3 mt-3">
                <label>Contact:</label>
                <asp:TextBox runat="server" Enabled="false"  CssClass="form-control" ID="txtContact"></asp:TextBox>
              
            </div>
             <div class="mb-3 mt-3">
                <label>Email:</label>
                <asp:TextBox runat="server" Enabled="false"  CssClass="form-control" ID="txtEmail"></asp:TextBox>
              
            </div>

            <div class="mb-3 mt-3">
                <label>City:</label>
               <asp:TextBox runat="server" Enabled="false"  CssClass="form-control" ID="txtCity"></asp:TextBox>
              
            </div>

                 <div class="mb-3 mt-3">
    <label>Profile Photo:</label>
    <asp:Image runat="server" Height="300px" ID="imgProfilePhoto" />
                     <hr />
    <asp:Image runat="server" ID="thumbImg" />
  
</div>
           

          
            
        </div>
   



</asp:Content>
