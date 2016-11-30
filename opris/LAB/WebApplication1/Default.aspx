<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <%--    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Авито</h2>
            </hgroup>
            <p>
                &nbsp;</p>
         <!--   <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar> -->
        </div>
    </section>--%>
    <div>
                
            
    </div>
  <script>
      var pn = this.sq.parentNode;
      pn.insertBefore(div, bef);
  </script>
    
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div style="height: 148px">
        <asp:ImageButton runat="server" ImageUrl="~/Images/orderedList0.png" CssClass="leftimg"  Width="109px" ></asp:ImageButton>
        <p>товар</p>
        <p >Продавец</p>
    </div>
    <div style="height: 148px">
         <asp:ImageButton runat="server" ImageUrl="~/Images/orderedList0.png" CssClass="leftimg" Width="109px"></asp:ImageButton>
        <p>Продавец</p>
        <p>
       
            товар</p>
    </div>
            
;
        
</asp:Content>
