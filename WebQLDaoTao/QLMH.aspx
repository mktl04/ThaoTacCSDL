﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="QLMH.aspx.cs" Inherits="WebQLDaoTao.QLMH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h2>NỘI DUNG TRANG QUẢN LÝ MÔN HỌC</h2>
    <hr />
    <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-8">
            <h4>DANH SÁCH MÔN HỌC</h4>
            <asp:GridView CssClass="table table-bordered"
                ID="gvMonHoc" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Mã môn học" DataField="MaMH" />
                    <asp:BoundField HeaderText="Tên môn học" DataField="TenMH" />
                    <asp:BoundField HeaderText="Số tiết" DataField="SoTiet" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btEdit" CommandName="Edit" runat="server" Text="Sửa"
                                CssClass="btn btn-success" />
                            <asp:Button ID="btDelete" CommandName="Delete" runat="server"
                                Text="Xóa" CssClass="btn btn-danger" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Button ID="btUpdate" CommandName="Update" runat="server"
                                Text="Ghi" CssClass="btn btn-success" />
                            <asp:Button ID="btCancel" CommandName="Cancel" runat="server"
                                Text="Không" CssClass="btn btn-danger" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <HeaderStyle BackColor="#003399" ForeColor="#ffffff" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>