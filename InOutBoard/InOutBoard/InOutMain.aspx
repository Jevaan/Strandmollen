<%@ Page Title="" Language="C#" MasterPageFile="~/InOut.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="InOutMain.aspx.cs" Inherits="InOutBoard.InOutMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
  
    <asp:Timer ID="UpdateTimer" runat="server" Interval="10000" OnTick="UpdateTimer_Tick">
    </asp:Timer>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate><table><tr><td style="width:500px">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InOutBoardConnectionString %>" SelectCommand="SELECT [EID], [Name], [JobTitel], [Email], [Status], [Picture], [Department], [Color] FROM [ListAll] ORDER BY [Department], [Name]"></asp:SqlDataSource>
                <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <EditItemTemplate>
            <li style="background-color: #999999;">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                JobTitel:
                <asp:TextBox ID="JobTitelTextBox" runat="server" Text='<%# Bind("JobTitel") %>' />
                <br />
                Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />
                Status:
                <asp:TextBox ID="StatusTextBox" runat="server" Text='<%# Bind("Status") %>' />
                <br />
                Picture:
                <asp:TextBox ID="PictureTextBox" runat="server" Text='<%# Bind("Picture") %>' />
                <br />
                Department:
                <asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            No data was returned.
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <li style="">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />JobTitel:
                <asp:TextBox ID="JobTitelTextBox" runat="server" Text='<%# Bind("JobTitel") %>' />
                <br />Email:
                <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                <br />Status:
                <asp:TextBox ID="StatusTextBox" runat="server" Text='<%# Bind("Status") %>' />
                <br />Picture:
                <asp:TextBox ID="PictureTextBox" runat="server" Text='<%# Bind("Picture") %>' />
                <br />Department:
                <asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            </li>
        </InsertItemTemplate>
        <ItemSeparatorTemplate>
<br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
                <table>
        <tr>
            <td><div id="navi">
<span class="menu"><table class="bordered" style="background-color:<%# Eval("Color") %>" aria-haspopup="true"><tr><td style="width:100px;text-align:center">
                
                           <img src="<%# ImagePath(Eval("Picture")) %>" />
                        </td><td style="width:225px">
                            <table>
                                <thead>
                                <tr><td><b><asp:Label ID="NameLabel" CssClass="disptext" runat="server" Text='<%# Eval("Name") %>' /></b></td>                                    
                                </tr></thead>
                                <tr><td><asp:Label ID="TitelLabel" CssClass="disptextsmall" runat="server" Text='<%# Eval("JobTitel") %>' /></td></tr>
                                <tr>
                                    <td><asp:Label ID="StatusLabel" CssClass="disptext" runat="server" Text='<%# Eval("Status") %>' /></td>
                                </tr>
                            </table></td>

               </tr></table> </span>
    <nav class="drop">
        
       <!-- <asp:Button ID="NotifyLabel" CssClass="menuoption" runat="server" Text='Meld Ankomst' ClientIDMode="Static" PostBackUrl='<%# Eval("EID", "InOutMain.aspx?Option=Notify&ID={0}") %>' /><br />-->
        <asp:Button ID="AvailableLabel" CssClass="menuoption" runat="server" Text='Ledig' PostBackUrl='<%# Eval("EID", "InOutMain.aspx?Option=1&ID={0}") %>' /><br />
        <asp:Button ID="BusyLabel" CssClass="menuoption" runat="server" Text='Optaget' PostBackUrl='<%# Eval("EID", "InOutMain.aspx?Option=3&ID={0}") %>' /><br />
        <asp:Button ID="OutLabel" CssClass="menuoption" runat="server" Text='Ude af huset' PostBackUrl='<%# Eval("EID", "InOutMain.aspx?Option=2&ID={0}") %>' />
    </nav>
</div> <br />
            </td>
            
        </tr>
    </table>

        </ItemTemplate>
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF;">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="bordered">Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                JobTitel:
                <asp:Label ID="JobTitelLabel" runat="server" Text='<%# Eval("JobTitel") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Status:
                <asp:Label ID="StatusLabel" runat="server" Text='<%# Eval("Status") %>' />
                <br />
                Picture:
                <asp:Label ID="PictureLabel" runat="server" Text='<%# Eval("Picture") %>' />
                <br />
                Department:
                <asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
                <br />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>
        </td><td style="width:50px"> </td>
            <td style="vertical-align:top;width:500px">
                Gæster
                <asp:SqlDatasource ID="SqlDataGuests" runat="server" ConnectionString="<%$ ConnectionStrings:InOutBoardConnectionString %>" SelectCommand="SELECT [Name], [Company], [Host], [ID] FROM [InHouseGuests] ORDER BY [Name]" InsertCommand="INSERT INTO Guests (Name,Company,Host) VALUES (@Name,@Company,@Host)">
          <insertparameters>
              <asp:ControlParameter Name="Name" ControlID="ctl00$ContentPlaceHolder1$ListView2$ctrl0$NameBox" PropertyName="Text" />
              <asp:ControlParameter Name="Company" ControlID="ctl00$ContentPlaceHolder1$ListView2$ctrl0$CompanyBox" PropertyName="Text" />
              <asp:ControlParameter Name="Host" ControlID="ctl00$ContentPlaceHolder1$ListView2$ctrl0$HostBox" PropertyName="SelectedValue" />
          </insertparameters>
      </asp:SqlDatasource>
                <asp:SqlDataSource ID="SqlDataHosts" runat="server" ConnectionString="<%$ ConnectionStrings:InOutBoardConnectionString %>" SelectCommand="SELECT [Name], [Email], [ID] FROM [Employee] ORDER BY [Name]"></asp:SqlDataSource>
                                <asp:ListView ID="ListView2" runat="server" DataSourceID="SqlDataGuests">
        <EditItemTemplate>
            <li style="background-color: #999999;">Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                JobTitel:
                <asp:TextBox ID="CompanyTextBox" runat="server" Text='<%# Bind("Company") %>' />
                <br />
                Email:
                <asp:TextBox ID="HostBox" runat="server" Text='<%# Bind("Host") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            </li>
        </EditItemTemplate>
        <EmptyDataTemplate>
            No data was returned.
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <table class="bordered" style="background-color:#ABC5DB" aria-haspopup="true"><tr><td style="width:100px;text-align:center">
                
                           <img src="<%# ImagePath("guest") %>" />
                        </td><td style="width:225px">
                            <table>
                                <thead>
                                <tr><td><b><asp:Textbox ID="NameBox" CssClass="disptext" runat="server" Text='Ny gæst' Width="125px" /></b></td>                                    
                                </tr></thead>
                                <tr><td><asp:Textbox ID="CompanyBox" CssClass="disptextsmall" runat="server" Text='Firma' Width="125px" /></td></tr>
                                <tr>
                                    <td><asp:DropDownList ID="HostBox" CssClass="disptext" runat="server" DataSourceID="SqlDataHosts"  AppendDataBoundItems="true" DataTextField="Name" DataValueField="ID" Width="125px">
    <asp:ListItem Text="Vært" Value="" />   
</asp:DropDownList><asp:Button ID="Button1" runat="server" CommandName="InsertGuest" Text="OK" OnClick="InsertGuest"/></td>
                                </tr>
                            </table></td>

               </tr></table>
            
        </InsertItemTemplate>
        <ItemSeparatorTemplate>
<br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
                <table>
        <tr>
            <td><div id="navi">
<span class="menu"><table class="bordered" style="background-color:#ABC5DB" aria-haspopup="true"><tr><td style="width:100px;text-align:center">
                
                           <img src="<%# ImagePath("guest") %>" />
                        </td><td style="width:225px">
                            <table>
                                <thead>
                                <tr><td><b><asp:Label ID="NameLabel" CssClass="disptext" runat="server" Text='<%# Eval("Name") %>' /></b></td>                                    
                                </tr></thead>
                                <tr><td><asp:Label ID="TitelLabel" CssClass="disptextsmall" runat="server" Text='<%# Eval("Company", "Firma: {0}") %>' /></td></tr>
                                <tr>
                                    <td><asp:Label ID="StatusLabel" CssClass="disptext" runat="server" Text='<%# Eval("Host", "Vært: {0}") %>' /></td>
                                </tr>
                            </table></td>

               </tr></table> </span>
    <nav class="drop">
        
      
        <asp:Button ID="OutLabel" CssClass="menuoption" runat="server" Text='Ude af huset' PostBackUrl='<%# Eval("ID", "InOutMain.aspx?Guest=1&Option=Out&ID={0}") %>' />
    </nav>
</div> <br />
            </td>
            
        </tr>
    </table>

        </ItemTemplate>
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF;">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="bordered">Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                <br />
                JobTitel:
                <asp:Label ID="JobTitelLabel" runat="server" Text='<%# Eval("JobTitel") %>' />
                <br />
                Email:
                <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                <br />
                Status:
                <asp:Label ID="StatusLabel" runat="server" Text='<%# Eval("Status") %>' />
                <br />
                Picture:
                <asp:Label ID="PictureLabel" runat="server" Text='<%# Eval("Picture") %>' />
                <br />
                Department:
                <asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
                <br />
            </li>
        </SelectedItemTemplate>
    </asp:ListView>

            </td></tr></table>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="UpdateTimer" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
<!-- Element to pop up -->
<div id="element_to_pop_up"> <a class="b-close">x<a/>
    Der er sendt besked om at du venter.
</div>
   <asp:Label ID="DebugLabel" Text="" runat="server"></asp:Label>
</asp:Content>
