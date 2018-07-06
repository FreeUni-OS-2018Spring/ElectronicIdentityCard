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
                            <asp:TextBox runat="server" CssClass="form-control" placeholder="სახელი გვარი" ID="txtName" />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <asp:TextBox runat="server" CssClass="form-control" ID="txtPersonalNumber" placeholder="პირადი ნომერი" />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <asp:DropDownList runat="server" ID="lstBirthPlace" CssClass="form-control" Height="34px" placeholder="დაბადების ადგილი"></asp:DropDownList>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <br />
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <asp:TextBox runat="server" placeholder="დაბადების თარიღი-დან" CssClass="form-control datepicker-field" ID="dtBirthDateFrom" />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <asp:TextBox runat="server" CssClass="form-control datepicker-field" placeholder="დაბადების თარიღი-მდე" ID="dtBirthDatTo" />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                             <asp:Button runat="server" ID="btnSearch" CssClass="btn btn-success" Text="Search" OnClick="btnSearch_Click" />
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <br />
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <asp:TextBox runat="server" placeholder="მოქმედების ვადა-დან" CssClass="form-control datepicker-field" ID="dtDateOfExpiryFrom" />
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                            <asp:TextBox runat="server" placeholder="მოქმედების ვადა-მდე" CssClass="form-control datepicker-field" ID="dtDateOfExpiryTo" />

                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-horizontal">
                          <asp:Button runat="server" ID="btnClearFilter" CssClass="btn btn-primary"  Text="Clear Filter" OnClick="btnClearFilter_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="col-md-12">
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/New.aspx" CssClass="btn btn-success" runat="server">Add New</asp:HyperLink>
    </div>
    <br />
    <div class="col-md-12">
        <div class="card">
            <div class="card-body">

                <asp:GridView ID="dgvCards" runat="server"
                    CssClass="table table-hover table-responsive-md table-fixed" GridLines="None"
                    AutoGenerateColumns="False" OnRowCommand="dgvCards_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />

                        <asp:TemplateField HeaderText="FullName">
                            <ItemTemplate>
                                <asp:Label ID="lblFullName" runat="Server" Text='<%# $"{Eval("FirstName")} {Eval("LastName")}"  %>' />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="PersonalNumber" HeaderText="Personal Number" />
                        <asp:BoundField DataField="Gender.Name" HeaderText="Gender" />
                        <asp:TemplateField HeaderText="BirthDate">
                            <ItemTemplate>
                                <asp:Label ID="lblBirthDate" runat="Server" Text='<%# DateTime.Parse(Eval("BirthDate").ToString()).ToString("dd/MM/yyyy")  %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date Of Expiry">
                            <ItemTemplate>
                                <asp:Label ID="DateOfExpiry" runat="Server" Text='<%# DateTime.Parse(Eval("BirthDate").ToString()).ToString("dd/MM/yyyy")  %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Actions">
                            <ItemTemplate>
                                <asp:Button runat="server" ID="btnEdit" CommandName="editRecord"  CommandArgument='<%# Eval("ID") %>'  ControlStyle-CssClass="btn btn-primary" ButtonType="Button" Text="Edit" HeaderText="Edit Record"></asp:Button>
                                <asp:Button runat="server" ID="btnDelete" CommandName="deleteRecord" CommandArgument='<%# Eval("ID") %>'  ControlStyle-CssClass="btn btn-danger" ButtonType="Button" Text="Delete" HeaderText="Delete Record"></asp:Button>
                            </ItemTemplate>
                        </asp:TemplateField>
                            

                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>

            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $('.datepicker-field').datetimepicker({
                format: 'YYYY-MM-DD'
            });
        });
    </script>
</asp:Content>
