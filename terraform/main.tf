provider "azurerm" {
version = "=1.44.0"
}

resource "azurerm_resource_group" "rg" {
  name     = "sample-resources"
  location = "westus2"
}