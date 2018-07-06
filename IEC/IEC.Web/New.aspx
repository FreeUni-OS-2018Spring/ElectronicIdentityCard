<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="IEC.Web.New" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6 col-md-offset-2">
            <div id="filter-panel">
                <div class="card card-body">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">სახელი</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">გვარი</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">მოქალაქეობა</label>
                                <div class="col-sm-8">
                                    <asp:DropDownList ID="dwlCitizenship" CssClass="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">სქესი</label>
                                <div class="col-sm-8">
                                    <asp:DropDownList runat="server" type="text" CssClass="form-control" ID="lstGenders"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">პირადი ნომერი</label>
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="lstPersonalNumber" />
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">დაბადების თარიღი</label>
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" CssClass="form-control datepicker-field" ID="dtBirthDate" ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">გაცემის თარიღი</label>
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" CssClass="form-control datepicker-field" ID="dtIssueDate" ></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">მოქმედების ვადა</label>
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" CssClass="form-control datepicker-field" ID="dtExperationDate" />
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">დაბადების ადგილი</label>
                                <div class="col-sm-8">
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="lstBirthPlaces"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">ბარათის N#</label>
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtNumber" />
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal" style="text-align: center">
                                <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Button" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <script>
        $(document).ready(function () {
            $('.datepicker-field').datetimepicker({
                format: 'DD/MM/YYYY'
            });
        });
    </script>
</asp:Content>
