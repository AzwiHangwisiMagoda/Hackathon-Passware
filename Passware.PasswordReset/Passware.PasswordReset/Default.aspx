<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Passware.PasswordReset._Default" %>

<asp:Content ID="Head" ContentPlaceHolderID="Head" runat="server">
    <link href="Content/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <%--logo--%>
            <%--<div id="logo" class="">
                <a title="Log On" href="/">
                    <img src="/images/logo.svg" alt="Logo" />
                </a>
            </div>--%>

    <div id="outerDiv" class="container">
        <div id="content">
            <%--logo--%>
            <div id="logo" class="">
                <a title="Log On" href="/">
                    <img src="/images/logo.svg" alt="Logo" />
                </a>
            </div>

            <%--header--%>
            <%--<h2>Login</h2>--%>

            <%--form--%>
            <div id="form">
                <div class="divEmail">
                    <input type="email" id="email" placeholder="username@company.com" required autofocus>
                </div>

                <div class="divPass">
                    <input type="password" id="password" placeholder="Password" required>
                </div>

                <a href="ForgotPass.aspx">Forgot Password?</a>
            </div>

            <%--button--%>
            <asp:Button Text="Log On" runat="server" />
            
        </div>
        
        
        
    </div>
</asp:Content>
