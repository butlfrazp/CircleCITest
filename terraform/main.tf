terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "=3.0.0"
    }
  }

  backend "azurerm" {
    resource_group_name  = "pb-tfstate-rg"
    storage_account_name = "pbtfstate"
    container_name       = "tfstate"
    key                  = "terraform.tfstate"
  }
}

provider "azurerm" {
  features {}
}

locals {
  resource_group_name  = "${var.prefix}-${var.env}-${var.location}"
  storage_account_name = "${var.prefix}${var.env}${var.location}sa"
}


resource "azurerm_resource_group" "rg" {
  name     = local.resource_group_name
  location = var.location
  tags = {
    Environment = var.env
  }
}

resource "azurerm_storage_account" "example" {
  name                     = local.storage_account_name
  resource_group_name      = azurerm_resource_group.rg.name
  location                 = azurerm_resource_group.rg.location
  account_tier             = "Standard"
  account_replication_type = "GRS"

  tags = {
    Environment = var.env
  }
}

resource "azurerm_storage_container" "example" {
  name                  = "container"
  storage_account_name  = azurerm_storage_account.example.name
  container_access_type = "private"
}