<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelatorioVotos.aspx.cs" Inherits="PesquisaEleitoral.DataSet.RelatorioVotos" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <LocalReport ReportPath="DataSet\ReportVoto.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataVoto" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:Button ID="btn_VoltarThree" runat="server" OnClick="btn_VoltarThree_Click" Text="Voltar" />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PesquisaEleitoral._aspnet_PesquisaEleitoral_20160923093922DataSetTableAdapters.VotosTableAdapter"></asp:ObjectDataSource>
    </form>
</body>
</html>
