<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCust.aspx.cs" Inherits="Lab2.AddCust" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <asp:Table ID="Table2" runat="server" Width="300px">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnPopulateCust" runat="server" Text="Populate" OnClick="btnPopulateCust_Click" CausesValidation ="false"  />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                         <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CausesValidation="false" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2">
                        <asp:Button ID="btnCommitAddCust" runat="server" Text="Commit" OnClick="btnCommitAddCust_Click"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnGenerateCustomerID" runat="server" Text="Generate New Customer ID" OnClick="btnGenerateCustomerID_Click" CausesValidation="false"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>


<%--            Form to Add Customer Data--%>
            <asp:Table ID="Table3" runat="server" Width="1244px">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtFirstName" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtLastName" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPhoneType" runat="server" Text="PhoneType"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButtonList ID="rdoPhoneType" runat="server">
                            <asp:ListItem Value ="Home">Home</asp:ListItem>
                            <asp:ListItem Value="Work">Work</asp:ListItem>
                            <asp:ListItem Value="Cell" Selected="True">Cell</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number"></asp:Label>
                    </asp:TableCell>
                      <asp:TableCell>
                          <asp:TextBox ID="txtPhoneNo" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtPhoneNo" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtEmail" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    </asp:TableCell>
                      <asp:TableCell>
                          <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtAddress" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtCity" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                    </asp:TableCell>
                      <asp:TableCell>
                          <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtState" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblZip" runat="server" Text="Zip Code"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtZip" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtZip" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtCustomerID" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                </asp:Table>
                <br />

                <asp:Table ID="tblInitialContact" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblContact" runat="server" Text="How did the Customer Initally Contact Us?"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlContact" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlContact_SelectedIndexChanged">
                            <asp:ListItem Value ="In Person">In Person</asp:ListItem>
                            <asp:ListItem Value ="By Phone">By Phone</asp:ListItem>
                            <asp:ListItem Value ="Email">Email</asp:ListItem>
                            <asp:ListItem Value ="Text">Text</asp:ListItem>
                            <asp:ListItem Selected="true" Value ="Other">Other</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtOther" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                      <asp:TableCell>
                        <asp:Label ID="lblHearAbout" runat="server" Text="How did the Customer Hear About Us?"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtHearAbout" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtHearAbout" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblServInterested" runat="server" Text="What Service Are the Interested in Today?"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButtonList ID="rdobtnServ" runat="server"  OnSelectedIndexChanged="rdobtnServ_SelectedIndexChanged">
                            <asp:ListItem Value="Auction">Auction</asp:ListItem>
                            <asp:ListItem Value="Moving" Selected="True">Moving</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lbltoAddress" runat="server" Text=" Moving Address"></asp:Label>
                    </asp:TableCell>
                      <asp:TableCell>
                          <asp:TextBox ID="txtMovingAddress" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblMovingCity" runat="server" Text="City"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtMovingCity" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblMovingState" runat="server" Text="State"></asp:Label>
                    </asp:TableCell>
                      <asp:TableCell>
                          <asp:TextBox ID="txtMovingState" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblMovingZip" runat="server" Text="Zip Code"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="txtMovingZip" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDateTime" runat="server" Text="Date and Time of Initial Contact"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDateTime" runat="server" AutoPostBack="true" TextMode="DateTime"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtDateTime" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDeadline" runat="server" Text="Deadline for your Service (One Date and Time or a Range)?"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDeadline" runat="server" Text ="Date"></asp:TextBox>
                        <asp:TextBox ID="txtTime" runat="server"  Text="Time"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDeadline2" runat="server" Text ="Date"></asp:TextBox>
                        <asp:TextBox ID="txtTime2" runat="server" Text ="Time" ></asp:TextBox>
                    </asp:TableCell>

                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtDeadline" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtTime" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>

                    </asp:TableCell>

                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnAddServForCust" runat="server" Text="Add a New Service Event for the Customer"  OnClick="btnAddServForCust_Click"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>


            

</asp:Content>
