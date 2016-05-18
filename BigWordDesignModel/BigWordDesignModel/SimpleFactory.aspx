<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleFactory.aspx.cs" Inherits="BigWordDesignModel.SimpleFactory" MasterPageFile="~/Site1.Master" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>第一章 簡單工廠模式</h1>
    需求:輸入兩個數字 及運算符號 (+或- ) 回傳結果
        <br />
    第一個數字:<asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox><br />
    第二個數字:<asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>&nbsp;<br />
    運算符號:<asp:TextBox ID="txtOpration" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnSubmit" runat="server" Text="勇者計算" OnClick="btnSubmit_Click" /><br />
    <asp:Button ID="btnDone" runat="server" Text="工程師計算" OnClick="btnDone_Click" /><br />
    結果:<asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
    <br />

    <asp:Button ID="btnBrave" runat="server" Text="勇者模式說明" OnClick="btnBrave_Click" /><br />
    <asp:Panel ID="pl_Brave" runat="server" Visible="false">
        勇者計算方式說明:<br />
        如果今天要新增一個計算功能(*)時程式需重新改寫，此時有可能會寫錯(但編譯通過)影響到目前可以用的功能(+、-)<br />
        所以應該針對功能以繼承、多型方式進行重構<br />
        <br />

        <asp:Button ID="btnCreateClass" runat="server" Text="我做好類別了" OnClick="btnCreateClass_Click" /><br />

    </asp:Panel>
    <asp:Panel ID="pl_Factory" runat="server" Visible="false">
        問題說明:<br />
        類別都完成後要如何產生哪一個物件呢? 我做了三個功能的類別<br />
        所以應該需要一個單獨的類別來創造物件的過程 這就是簡單工廠模式<br />


    </asp:Panel>
</asp:Content>
