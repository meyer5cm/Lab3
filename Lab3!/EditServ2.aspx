<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditServ2.aspx.cs" Inherits="Lab2.EditServ2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
             <asp:Table ID="tblDrop" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDropDownList" runat="server" Text="Choose a Service to View"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:dropDownList ID="ddlService" runat="server" AutoPostBack="true" DataSourceID="datasrcCustomerList" DataTextField="fullName" DataValueField="CustomerID" OnSelectedIndexChanged="ddlService_SelectedIndexChanged" ></asp:dropDownList>
                    </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>


    
    <asp:Table ID="Table5" runat="server">
       <asp:TableRow>
           <asp:TableCell>
               <asp:GridView runat="server" ID="grdvwServTicketDisplay" EmptyDataText="No Service Selected!"></asp:GridView>
           </asp:TableCell>
       </asp:TableRow>
     </asp:Table>


               <asp:SqlDataSource ID="datasrcCustomerList" runat="server" ConnectionString="<%$ ConnectionStrings:Lab2 %>" SelectCommand="SELECT CustFirstName + ' ' +  CustLastName + ' ' + Service.ServiceDate AS fullName, Customer.CustomerID FROM Customer INNER JOIN Service ON Customer.CustomerID = Service.CustomerID"></asp:SqlDataSource>


                    <asp:Table ID="tblTxtBox" runat="server" style ="float:left" Width="277px">
                <asp:TableRow HorizontalAlign="Center">
                    <asp:TableCell>
                        <asp:Label ID="lblNotes" runat="server" Text="Notes"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtHeader" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="txtNote" runat="server" TextMode="MultiLine" Rows ="15"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <asp:Table ID="tblAddServ" runat="server" HorizontalAlign="Right">
                    <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnUpdateServ" runat="server" Text="Update" OnClick="btnUpdateServ_Click" CausesValidation ="false" />
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="btnClearServ" runat="server" Text="Clear" OnClick="btnClearServ_Click" CausesValidation="false"/>
                        </asp:TableCell>
                    </asp:TableRow>

                </asp:Table>

           
     <asp:Table ID="Table3" runat="server" Width="737px" HorizontalAlign ="Center">
                  <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblServiceType" runat="server" Text="Service Type (Moving or Auction)"></asp:Label>
                     </asp:TableCell> 
                     <asp:TableCell>
                         <asp:TextBox ID="txtServType1" runat="server"></asp:TextBox>
                    </asp:TableCell>                    
                </asp:TableRow>
                 <asp:TableRow>
                     <asp:TableCell>
                        <asp:Label ID="lblFirstName1" runat="server" Text="Customer First Name"></asp:Label>
                     </asp:TableCell> 
                     <asp:TableCell>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                     <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtFirstName" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
             </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblLastName" runat="server" Text="Customer Last Name"></asp:Label>
                    </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtLastName" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblCustID" runat="server" Text="Customer ID"></asp:Label>
                    </asp:TableCell> 
                    <asp:TableCell>
                        <asp:TextBox ID="txtCustID1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtCustID1" Operator="DataTypeCheck" Type="Integer" ForeColor="Red" Text ="Entry must be a 9 digit integer!"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDate" runat="server" Text="Service Date "></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDate1" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                     <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="CompareValidator" 
                         ControlToValidate="txtDate1" Operator="DataTypeCheck" Type="Date" ForeColor="Red" Text ="Entry must be a Date!"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEstCost" runat="server" Text="Estimated Cost"></asp:Label>
                     </asp:TableCell>
                     <asp:TableCell>
                        <asp:TextBox ID="txtEstCost1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                    <asp:CompareValidator ID="CompareValidator4" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtEstCost1" Operator="DataTypeCheck" Type="Currency" ForeColor="Red" Text ="Enter an amount in dollars, excluding ($)!"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblCompDate" runat="server" Text="Completion Date"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtCompDate1" runat="server"></asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:CompareValidator ID="CompareValidator5" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtCompDate1" Operator="DataTypeCheck" Type="Date" ForeColor="Red" Text ="Entry must be a Date!"></asp:CompareValidator>

                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblMoveTime" runat="server" Text="Move Time (Days)"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtMoveTime1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                            <asp:CompareValidator ID="CompareValidator6" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtMoveTime1" Operator="DataTypeCheck" Type="Integer" ForeColor="Red" Text ="Entry must be an integer (# of days)!"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblServiceID" runat="server" Text="Service ID "></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtServiceID1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                     <asp:TableCell>
                    <asp:CompareValidator ID="CompareValidator7" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtServiceID1" Operator="DataTypeCheck" Type="Integer" ForeColor="Red" Text ="Entry must be a 6 digit integer!"></asp:CompareValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblVehicleUsed" runat="server" Text="Vehicle Used"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtVehicleUsed1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEquip" runat="server" Text="Equipment Needed"></asp:Label>
                     </asp:TableCell>
                     <asp:TableCell>
                        <asp:TextBox ID="txtEquip1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDestinationAddress" runat="server" Text="Destination Address"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDestinationAddress1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtDestinationAddress1" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDestinationCity1" runat="server" Text="City"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDestinationCity1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtDestinationCity1" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label2" runat="server" Text="State"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDestinationState1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtDestinationState1" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Label3" runat="server" Text="Zip"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtDestinationZip1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                            <asp:CompareValidator ID="CompareValidator" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtDestinationZip1" Operator="DataTypeCheck" Type="Integer" ForeColor="Red" Text ="Entry must be a 5 digit integer!"></asp:CompareValidator>
                    </asp:TableCell>           
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>                       
                    <asp:Label ID="lblLodgeCost" runat="server" Text="Lodging Cost"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>                       
                    <asp:TextBox ID="txtLodgeCost1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                            <asp:CompareValidator ID="CompareValidator9" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtLodgeCost1" Operator="DataTypeCheck" Type="Currency" ForeColor="Red" Text ="Enter an amount in dollars, excluding ($)!)"></asp:CompareValidator>
                    </asp:TableCell>
                    </asp:TableRow>
                <asp:TableRow>
                     <asp:TableCell>                       
                     <asp:Label ID="lblFuelCost" runat="server" Text="Fuel Cost"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>                       
                    <asp:TextBox ID="txtFuelCost1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                            <asp:CompareValidator ID="CompareValidator10" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtFuelCost1" Operator="DataTypeCheck" Type="Currency" ForeColor="Red" Text ="Enter an amount in dollars, excluding ($)!"></asp:CompareValidator>
                    </asp:TableCell>
                 </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell>                       
                    <asp:Label ID="lblFoodCost" runat="server" Text="Food Cost"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>                       
                    <asp:TextBox ID="txtFoodCost1" runat="server"></asp:TextBox>
                    </asp:TableCell>
                     <asp:TableCell>
                            <asp:CompareValidator ID="CompareValidator11" runat="server" ErrorMessage="CompareValidator" 
                            ControlToValidate="txtFoodCost1" Operator="DataTypeCheck" Type="Currency" ForeColor="Red" Text ="Enter an amount in dollars, excluding ($)!"></asp:CompareValidator>
                     </asp:TableCell>
                 </asp:TableRow>
         </asp:Table>

        <asp:Table ID="tblServiceTicket" runat="server">
          <asp:TableRow>
                 <asp:TableCell>
                        <asp:Button ID ="btnViewTicket" runat="server" Text="View Ticket for this Service Event" OnClick="btnViewTicket_Click" CausesValidation = "false"/>
                 </asp:TableCell>
            </asp:TableRow>  
       <asp:TableRow>
           <asp:TableCell>
               <asp:GridView runat="server" ID="grdvwTicketDisplay" EmptyDataText="No Service Selected!"></asp:GridView>
           </asp:TableCell>
       </asp:TableRow>
     </asp:Table>

    
    <asp:Table ID ="tblHistory" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEditServTicket" runat="server" Text="Edit Service Ticket History" Font-Size ="X-Large"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID = "lblHistID" runat="server" Text="Ticket History ID"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                        <asp:TextBox ID="txtHistID" runat="server" Text ="Auto-Filled"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID = "lblServTicketID" runat="server" Text="Service Ticket ID"></asp:Label>
                    </asp:TableCell>
                     <asp:TableCell>
                        <asp:TextBox ID="txtServTicketID" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtServTicketID" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>

                </asp:TableRow>
                        <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDateTime" runat="server" Text="Date and Time of History Change"></asp:Label>
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
                        <asp:Label ID="lblYourEmployeeID" runat="server" Text="Your Employee ID"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtYourEmployeeID" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" 
                ControlToValidate="txtYourEmployeeID" SetFocusOnError ="true" ForeColor="Red" Text ="Textfield Cannot be blank!"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                     <asp:TableCell>
                         <asp:Button ID ="btnTicketHistorySubmit" runat="server" Text="Submit New Ticket History"  OnClick ="btnTicketHistorySubmit_Click"/>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                     <asp:TableCell>
                         <asp:Button ID ="btnFullHistory" runat="server" Text="View Full Service Ticket History"  OnClick ="btnFullHistory_Click" CausesValidation="false"/>
                    </asp:TableCell>
                </asp:TableRow>

    </asp:Table>
</asp:Content>
