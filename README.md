
# About the Project [![CircleCI](https://dl.circleci.com/status-badge/img/gh/butlfrazp/CircleCITest/tree/master.svg?style=svg)](https://dl.circleci.com/status-badge/redirect/gh/butlfrazp/CircleCITest/tree/master)

This is a project that defines continuous integration pipeline workflows for CircleCI. Workflows that handles:

- Lint markdown files
- Lint yml configuration files
- Validate terraform files
- Preview the changes that terraform plans to make to the infrastructure
- Build, run unit tests for Azure functions

# Project Structure

- `.circleci/circleci_config.yml`: The configuration definition of all workflows. It specifies the docker image that contains tools to run the commands,
the order of the steps to execute in each workflow.
- `.circleci/config.yml`: Entry point that filters which workflows to execute based on the files modified in the most recent commit.
- `docs/`: Markdown files that describe documentation on subjects such as arquitecture design, features or faqs.
- `terraform/`: [Terraform files](https://www.terraform.io/intro) that document infrastructure resources. The current orchestrator deployment
is Circle CI.
