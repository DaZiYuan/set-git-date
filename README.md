# set-git-date
生成修改git提交时间的代码
仅用于powershell
```powershell
$Env:GIT_COMMITTER_DATE="2022-1-1 0:55"
$Env:GIT_AUTHOR_DATE ="2022-1-1 0:55"
git commit -a -m "msg"
```

# 用法
- 生成代码
```
//修改为8小时前
sgd -8

//修改时间并生成提价代码
sgd -8 message
```
- 然后右键粘贴代码
- 最后mmit可以手动添加`--amend``