<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IEC.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
        <div class="card card-body" style="text-align: center; cursor: pointer;" data-toggle="collapse" data-target="#filter-panel">
            ↕ Search ↕
       
        </div>
        <div id="filter-panel" class="collapse show">
            <div class="card card-body">
                <div class="row">
                    <br />
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <label for="input1" class="col-sm-3 control-label">Label</label>
                            <div class="col-sm-9">
                                <input type="text" class="form-control" id="input1" />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <label for="input1" class="col-sm-3 control-label">Label</label>
                            <div class="col-sm-9">
                                <input type="text" class="form-control" id="input2" />
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <label for="input1" class="col-sm-3 control-label">Label</label>
                            <div class="col-sm-9">
                                <input type="text" class="form-control" id="input2" />
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>
    </div>
    <br />
    <br />
    <div class="col-md-12">
        <div class="card">
            <div class="card-body">

                <asp:GridView ID="dgvUsers" runat="server"
                    CssClass="table table-hover table-responsive-md table-fixed" GridLines="None"
                    AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />

                        <asp:TemplateField HeaderText="FullName">
                            <ItemTemplate>
                                <asp:Label ID="lblFullName" runat="Server" Text='<%# $"{Eval("FirstName")} {Eval("LastName")}"  %>' />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="PersonalNumber" HeaderText="Personal Number" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" />
                        <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" />
                        <asp:BoundField DataField="DateOfExpiry" HeaderText="Date Of Expiry" />

                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:Button runat="server" CommandName="editRecord" ControlStyle-CssClass="btn btn-primary" ButtonType="Button" Text="Edit" HeaderText="Edit Record"></asp:Button>
                                <asp:Button runat="server" CommandName="editRecord" ControlStyle-CssClass="btn btn-danger" ButtonType="Button" Text="Delete" HeaderText="Delete Record"></asp:Button>
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
