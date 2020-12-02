// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#employeeTable').DataTable({
        scrollX: true,
        scrollY: true,
        filter: true,
        lengthChange: false,
        info: true,
        displayLength: 10,
        processing: true,

        ajax: {
            url: '/Home/GetEmployeeInfos/',
            type: "POST",
            dataType: "json"
        },
        language: {
            emptyTable: "",
            info: "_TOTAL_ 件中 _START_ 件から _END_ 件までを表示",
            infoEmpty: "該当する従業員情報がありません.",
            infoFiltered: "(_MAX_ 件からの絞り込み表示)",
            infoPostFix: "",
            thousands: ",",
            lengthMenu: "1ページあたりの表示件数: _MENU_",
            loadingRecords: "",
            processing: "処理中...",
            search: "検索",
            zeroRecords: "",

            paginate: {
                first: "先頭",
                previous: "前へ",
                next: "次へ",
                last: "末尾"
            }
        },
        columns: [
            { data: 'employee_no' },
            { data: 'first_name' },
            { data: 'last_name' },
            { data: 'full_name' },
            { data: 'department_code' },
            { data: 'postal_code' },
            { data: 'address' },
            { data: 'tel' },
            { data: 'birthday' },
            { data: 'sex' },
            { data: 'remarks' },
            { data: 'regist_date' },
            { data: 'update_date' }
        ],

        columnDefs: [
            // 従業員番号
            { targets: 0, width: 100 },
            // 名前
            { targets: 1, width: 100 },
            // 姓
            { targets: 2, width: 100 },
            // フルネ－ム
            { targets: 3, width: 200 },
            // 部署名
            { targets: 4, width: 150 },
            // 郵便番号
            { targets: 5, width: 100 },
            // 住所
            { targets: 6, width: 200 },
            // 電話番号
            { targets: 7, width: 150 },
            // 生年月日
            { targets: 8, width: 200 },
            // 性別
            { targets: 9, width: 50 },
            // 備考
            { targets: 10, width: 200 },
            // 登録日
            { targets: 11, width: 200 },
            // 更新日
            { targets: 12, width: 200 }
        ],
        initComplete: function () {
            console.log("callback");
        }
    });
});