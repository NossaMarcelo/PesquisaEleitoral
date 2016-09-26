<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelatorioData.aspx.cs" Inherits="PesquisaEleitoral.DataSet.RelatorioData" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" style="margin-bottom: 1px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <LocalReport ReportPath="DataSet\RelatorioFaixa.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataFaixaEtaria" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:Button ID="btn_VoltarTwo" runat="server" OnClick="btn_VoltarTwo_Click" Text="Voltar" />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="PesquisaEleitoral._aspnet_PesquisaEleitoral_20160923093922DataSetTableAdapters.DataVotoTableAdapter"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
