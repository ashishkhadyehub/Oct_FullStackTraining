<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="RepeaterExample.aspx.cs" Inherits="FullStackTraining.Sessions.RepeaterExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 style="text-align: center">ASP Repeater Example</h2>
        <div class="row">
        <asp:Repeater runat="server" ID="rPhotoGallery">
            <HeaderTemplate>
                <h3 style="text-align: center">Current Photos</h3>
            </HeaderTemplate>
            <ItemTemplate>

                <div class="col-md-4 my-2" style="">
                    <asp:Image runat="server" Style="width: 50%" ImageUrl='<%# Eval("ThumbPath") %>' />

                    <asp:Label runat="server" ID="photoid" Style="display: none" Text='<%# Eval("Srno") %>'></asp:Label>
                    <asp:LinkButton runat="server" ID="lbtndelete" OnClick="lbtndelete_Click" OnClientClick="return confirm('Do you want to delete this Photo?')" Style="background-color: orange; color: white; padding: 15px"><span class="fa fa-trash"></span> Delete</asp:LinkButton>

                </div>

            </ItemTemplate>
            <FooterTemplate>
                <h3 style="text-align: center">Thank you...!</h3>
            </FooterTemplate>
        </asp:Repeater>
            </div>
    </div>
</asp:Content>
