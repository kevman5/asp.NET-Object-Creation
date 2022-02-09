<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Object_Creation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <h1>Calculating the Volume and the Surface of a Sphere</h1>
    

            Radius:
            <asp:TextBox ID="tb_radius" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="calcvolume" runat="server" Text="Calculate" OnClick="calcvolume_Click"/>
            <br />
            Volume:
            <asp:TextBox ID="tb_volume" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
    
            Radius:  
            <asp:TextBox ID="tb_rad2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="calcSurface_Click"/>
            <br />
            Surface: <asp:TextBox ID="tb_surface" runat="server"></asp:TextBox>
          
        
       
</asp:Content>
