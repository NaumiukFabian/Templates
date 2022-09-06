<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Glowna.Master" CodeBehind="Rejestracja.aspx.cs" Inherits="Powtórzenie.Rejestracja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="podstrona" runat="server">
        <asp:CreateUserWizard OnCreatedUser="CreateUserWizard1_CreatedUser" OnContinueButtonClick="CreateUserWizard1_ContinueButtonClick" ID="CreateUserWizard1" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
</asp:Content>

