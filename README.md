# set-git-date
生成修改git提交时间的代码
仅用于powershell

```powershell
$Env:GIT_COMMITTER_DATE="2022-1-1 0:55"
$Env:GIT_AUTHOR_DATE ="2022-1-1 0:55"
git commit -a -m "msg"
```

---
# How to use
```
# install 
dotnet tool install --global SGD

# upgarde
dotnet tool update --global SGD
```
# run in commandline
```
//修改为8小时前
sgd -8

//修改时间并生成提交代码
sgd -8 message
```
- 右键粘贴代码
- commit代码可以手动添加`--amend`