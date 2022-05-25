ITP4915M_sales_system
===
管理員登入
---
Username: `root` Password: `root`
注意事項
---
### 在每一個新的From中必須先添加以下代碼
#### 添加 `MySqlConnection` and `Account_Details` class variable
```c#
public partial class Account_Management : Form{
        
    private MySqlConnection conn; // 添加在class內
    private Account_Details acc; // 添加在class內
        
    public Account_Management(MySqlConnection conn, Account_Details acc){ // (MySqlConnection conn, Account_Details acc)添加在constructor傳入變量內
        this.conn = conn; // 添加在constructor內
        this.acc = acc; // 添加在constructor內
        InitializeComponent();
    }
}
```
#### 添加 `FormClosed` and `FormLoad` 事件
```c#
private void Account_Management_FormClosed(object sender, FormClosedEventArgs e) {
    Program.removePage(); // 添加在FormClosed事件內
}

private void Account_Management_Load(object sender, EventArgs e) {
    Program.addPage(); // 添加在FormLoad事件內
}
```
#### 添加 `myProfile` 按鈕 `Click` 事件
```c#
private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
    new My_Profile(conn, acc).Show(); //添加在Click事件內
}
```
#### 添加 `logout` 按鈕 `Click` 事件
```c#
private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
    Application.Exit(); //添加在Click事件內
}
```
如何使用 `MySqlConnection`
---
#### `SELECT` 查詢
> 為防止sql injection攻擊<br>
> 所有擺放數據嘅位置, 需要用變量方式代替<br>
> Ex: SELECT * FROM staff WHERE AccountID = ***@accountID***<br>
> `@accountID` 係你需要擺放數據嘅位置<br>
> 
> `@` <--代表建立變量 Ex: ***@變量名稱***

```c#
try {
    MySqlCommand cmd = new MySqlCommand(/*sql語句*/, conn); // 建立查詢 
    cmd.Parameters.AddWithValue("@accountID", tb_username.Text); // 將數據放入變量
    MySqlDataReader data = cmd.ExecuteReader(); // 運行查詢

    if (!data.HasRows) { // 檢查是否存在數據
        // Do something 
    } else {
        while (data.Read()) { // 逐行讀取數據
            //取得該欄數據
            data.GetString(/*欄位名稱*/); 
            data.GetInt32(/*欄位名稱*/);
            data.GetBoolean(/*欄位名稱*/);
            data.GetFloat(/*欄位名稱*/)
                        
            // Do something
        }
        data.Close(); // 關閉查詢 必須添加執行!否則你無法進行下一次數據庫查詢
    }
} catch (MySqlException ex) { // 如果sql出現錯誤, 則執行這裏
     // Do something 
}
```
#### 其他非 `SELECT` 查詢
用法都是一樣, 但不需要任何操作
即是中間部分的code不需要寫
```C#
if (!data.HasRows) { // 檢查是否存在數據
    // Do something 
} else {
...
```
