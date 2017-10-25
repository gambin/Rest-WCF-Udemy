<%@  title="Teste" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="GetWSData.aspx.cs" inherits="GMBProj.GetWSData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="wrapper">
        <div class="l-field">Entre com os valores para realizar o cálculo:</div>
        <div class="i-field">
            <p>
                <asp:TextBox ID="num1" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:TextBox ID="num2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:DropDownList ID="sOperacao" runat="server"></asp:DropDownList></p>
            <p>
                <asp:Button ID="calcularBtn" runat="server" Text="Calcular" />
            </p>
        </div>
    </div>
    <div class="q-results">
        <p>
            Total:
            <asp:Label ID="totalizador" runat="server" Text=""></asp:Label>
        </p>

    </div>

</asp:Content>
