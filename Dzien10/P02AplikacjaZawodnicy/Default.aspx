<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Glowna.Master" CodeBehind="Default.aspx.cs" Inherits="Powtórzenie.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="podstrona" runat="server">
                <div class="row">
                    <div id="dvLadowanie" style="display: none">
                        <img src="https://miro.medium.com/max/700/1*cD8WMb82cSXACDTG8mlWhw.gif" style="width: 1000px; margin-top: 50px" />
                    </div>

                    <div class="col-md-12">
                        <%-- <p style="margin-top:60px">Loading...</p>--%>
                        <%--<img src="https://miro.medium.com/max/700/1*cD8WMb82cSXACDTG8mlWhw.gif" style="width: 1000px; margin-top: 50px" />--%>
                    </div>
                </div>
    

</asp:Content>
    
 <asp:Content ID="Content2" ContentPlaceHolderID="WlasneSkrypty" runat="server">
    <script src="DefaultJS.js"></script>
 </asp:Content>          

