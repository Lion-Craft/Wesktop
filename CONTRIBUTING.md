# How to contribute?

## General rules
- Please comment your code. A short explanation of what a (small) code block or line does, aswell as optionally noting small issues or TODOs, are required.
- Create issues if you find any bugs, possible improvements, have a feature request and more but only after you have searched existing issues for your request. 
  - Possible improvements and feature requests have to be evaluated and approved before any work should be done
  - Bug and approved feature & improvement issues must have a **bold** definiton of done (DoD for short) that clearly states when a issue can be considered completed
- Commit messages should briefly describe changes made aswell as mentioning the corresponding issue.

## Branches

- master:
  - Main stable branch. Do not directly commit to master.
- development:
  - Primary development branch. Push to this branch and open pull requests.

## Version numbering

Version numbering follows the following pattern:
[Major version].[Minor version].[Build].[Revision]
- Major version may be increased when the corresponding milestone is completed.
- Minor version may be increased by 1 for each issue completed within the current milestone, starting back at 0 when the milestone is completed.
- Build and Revision number will be automatically set by the compiler.
