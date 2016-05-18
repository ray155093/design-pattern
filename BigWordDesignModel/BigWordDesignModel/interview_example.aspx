<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="interview_example.aspx.cs" Inherits="BigWordDesignModel.interview_example"  MasterPageFile="~/Site1.Master" %>

<asp:content id="Content1" contentplaceholderid="ContentPlaceHolder1" runat="Server">
    <div>
    <h1>畫一個菱形 
        <asp:Button ID="Button1" runat="server" Text="畫一個菱形" OnClick="Button1_Click" />
        </h1>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </asp:content>
