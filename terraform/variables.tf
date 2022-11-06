variable "location" {
  type        = string
  default     = "westus2"
  description = "The location of the resources"
}

variable "env" {
  type        = string
  default     = "dev"
  description = "The environment."
}

variable "prefix" {
  type        = string
  default     = "pbtest54"
  description = "the prefix to add to the resources."
}
