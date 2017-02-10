# upskilling-c-sharp
From zero to hero, in C#

Workflow:

- Fork the repository
- For each issue in [issues](https://github.com/DeveintLabs/upskilling-c-sharp/issues), create a branch thus:
  
  ```
  <issue-number>-issue-tittle>
  e.g.
  1-hr-arraysum for the first issue on this repo.
  ```
- Your solutions should be put in a folder named `issue-<number>` (number padded with 0's) e.g. `issue-001`
- Work out your solution from the branch, then commit changes and push.
- Raise a PR against your `master` branch (not this project's master branch).
- Your PR will then be reviewed by your peers and merged appropriately

See example [here](https://github.com/ProfNandaa/upskilling-c-sharp/pull/1)


## Appendix

### Workflow Explained

Quick Git walkthrough:

- Fork the repo
- Clone your forked repo, e.g.
  
  ```
  git clone https://github.com/ProfNandaa/upskilling-c-sharp.git
  ```
- Create a branch for your solution, e.g.
  
  ```
  git checkout -b 1-hr-sum-array
  ```
- After making changes, stage the changes:
  
  ```
  git add --all
  ```
- Commit the staged changes, e.g.
  
  ```
  git commit -m "solution: hackerrank sum-array"
  ```
- Push your changes, e.g.

  ```
  git push origin 1-hr-sum-array
  ```

Making A pull request
<img width="1072" alt="screen shot 2017-02-10 at 10 25 15 am" src="https://cloud.githubusercontent.com/assets/261265/22818037/fdc35612-ef7b-11e6-9c3b-4d19287af4ae.png">

Reviewing Code
<img width="1063" alt="screen shot 2017-02-10 at 10 26 10 am" src="https://cloud.githubusercontent.com/assets/261265/22817993/b241c660-ef7b-11e6-8ca4-4fe405c95b4d.png">

