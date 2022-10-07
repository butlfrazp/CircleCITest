# Best Practices

## Create Environment Variables For Secrets Management

You do not want to check your secrets into version control, and secrets should never be written in plain text in your config. For example:

```terraform
# Configure the Microsoft Azure Provider
provider "azurerm" {
  features {}

  subscription_id = "00000000-0000-0000-0000-000000000000"
  client_id       = "00000000-0000-0000-0000-000000000000"
  client_secret   = var.client_secret
  tenant_id       = "00000000-0000-0000-0000-000000000000"
}
```

It is recommend to store the secrets as environmental variables.

## Define Environment Variables Per Stage using CircleCI Contexts

Most environment will have at least two stages (dev and prod) and we do not want to add prefix in each environment variable. As an example:

```bash
DEV_ARM_SUBSCRIPTION_ID =  "00000000-0000-0000-0000-000000000000"
PROD_ARM_SUBSCRIPTION_ID = "11111111-1111-1111-1111-111111111111"
```

CircleCI provides you with access to [contexts](https://circleci.com/docs/contexts)where environment variables can be defined per stage.

These allow you to secure and share environment variables across projects in your organization. Contexts are essentially a secret store where you can
set environment variables as name/value pairs that are injected at runtime.
