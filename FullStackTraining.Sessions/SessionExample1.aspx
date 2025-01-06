<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="SessionExample1.aspx.cs" Inherits="FullStackTraining.Sessions.SessionExample1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
      <div>
          <h3>Session Example</h3>
          <asp:TextBox runat="server" ID="txtcount"></asp:TextBox>
          <asp:Button runat="server" OnClick="btnclick_Click" Text="Click" ID="btnclick" />
      </div>
  </div>
</asp:Content>
