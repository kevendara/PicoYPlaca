<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PicoYpPlaca.aspx.cs" Inherits="AplicacionWeb.PicoYpPlaca" %>

<%@ Import Namespace="Ext.Net.Utilities" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pico Y Placa</title>
    <script type="text/javascript">

    </script>
</head>
<body runat="server">
    <form runat="server" id="idform">

       
        <ext:ResourceManager runat="server" />

        <ext:TextField 
            ID="IdPicoPlaca" 
            runat="server"                    
            FieldLabel="Pico y Placa"
            AllowBlank="false"
            EmptyText="Ejemplo de Placa: AAC-0120"
            Width="500">  
        </ext:TextField>

        <ext:Button runat="server" ID="botonBuscar" Text="Ver" Icon="Find" Scale="Small" IconAlign="Bottom">
            <DirectEvents>
                <Click OnEvent="BuscarPlaca" />
            </DirectEvents>
        </ext:Button>

    </form>
</body>
</html>
