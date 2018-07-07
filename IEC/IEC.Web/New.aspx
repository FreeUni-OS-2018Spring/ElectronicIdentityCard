<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="IEC.Web.New" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6 col-md-offset-3">
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
                                    <asp:DropDownList ID="lstCitizenship" CssClass="form-control" Height="34px" runat="server"></asp:DropDownList>
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
                                    <asp:DropDownList runat="server" type="text" CssClass="form-control" Height="34px" ID="lstGenders"></asp:DropDownList>
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
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtPersonalNumber" />
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
                                    <asp:TextBox runat="server" CssClass="form-control datepicker-field" ID="dtBirthDate"></asp:TextBox>
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
                                    <asp:TextBox runat="server" CssClass="form-control datepicker-field" ID="dtIssueDate"></asp:TextBox>
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
                                    <asp:TextBox runat="server" CssClass="form-control datepicker-field" ID="dtDateOfExpiry" />
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
                                    <asp:DropDownList runat="server" CssClass="form-control" Height="34px" ID="lstBirthPlaces"></asp:DropDownList>
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
                            <div class="form-horizontal">
                                <label for="input1" class="col-sm-4 control-label">გამცემი ორგანო</label>
                                <div class="col-sm-8">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtOrganization" />
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="col-md-12">
                            <div class="form-horizontal" style="text-align: center">
                                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label><br />
                                <asp:Button ID="btnSave" CssClass="btn btn-success" runat="server" Text="შენახვა" OnClick="btnSave_Click" />
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
                format: 'YYYY-MM-DD'
            });

        });
    </script>
</asp:Content>
