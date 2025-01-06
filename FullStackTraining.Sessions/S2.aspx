<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="S2.aspx.cs" Inherits="FullStackTraining.Sessions.S2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-4">
            <div class="form-group my-2">
                <label>Enter Name:</label>
                <asp:TextBox Enabled="false" runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label>Enter Contact:</label>
                <asp:TextBox runat="server" Enabled="false" CssClass="form-control" ID="txtContact"></asp:TextBox>
            </div>
            
        </div>
    </div>
</div>
</asp:Content>
