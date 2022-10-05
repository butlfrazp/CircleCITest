# Authenticate Terraform to Azure
For Terraform to authentica to azure, it requires: Subscription ID, Client Secret, Client ID and Tenant ID. You can obtain Subscription ID easily in Subscriptions, but the remaining fields can be obtained through the next steps:

1. Register an application with Azure ActiveDirectory and create a service principal (i.e. sp-terraform-demo-contributor)
Create a new application secret
2. Assign a role to the application (Owner or Contributor)
3. Create a new application secret 
4. Register environment variables CirclesCI project > Project Settings > Environment Variables

```
ARM_CLIENT_ID="00000000-0000-0000-0000-000000000000"
ARM_CLIENT_SECRET="00000000-0000-0000-0000-000000000000"
ARM_SUBSCRIPTION_ID="00000000-0000-0000-0000-000000000000"
ARM_TENANT_ID="00000000-0000-0000-0000-000000000000"
```
Shortcut command: 
```
az ad sp create-for-rbac --name "sp-terraform-demo-contributor" \
  --role="Contributor" \
  --scopes="/subscriptions/<subscription ID>"
```

Related links:
* https://learn.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal
* https://learn.microsoft.com/en-us/azure/developer/terraform/authenticate-to-azure?tabs=bash
* https://registry.terraform.io/providers/hashicorp/azurerm/latest/docs/guides/service_principal_client_secret#configuring-the-service-principal-in-terraform