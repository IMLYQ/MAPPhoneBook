(function () {

    $(function () {
        var _personService = abp.services.app.person;
        var _$modal = $("#PersonCreateModal");

        var _$form = _$modal.find('form');

        //添加联系人功能
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }
            var personEditDto = _$form.serializeFormToObject();//序列化表单为对象

            personEditDto.PhoneNumbers = [];
            var phoneNumber = {};
            phoneNumber.Type = personEditDto.PhoneNumberType;
            phoneNumber.Number = personEditDto.PhoneNumber;
            personEditDto.PhoneNumbers.push(phoneNumber);

            //增加一个前端的机制，防止用户重复提交  设置忙碌状态
            abp.ui.setBusy(_$modal);

            //约定大约配置  服务方法名首字母必须小写
            _personService.createOrUpdatePerson({ personEditDto }).done(function () {
                _$modal.modal('hide');  //隐藏模态框
                //重新加载数据
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        //绑定删除事件  --delete-person为删除li中的class
        $('.delete-person').click(function () {
            var personId = $(this).attr("data-person-id"); //获取用户的ID
            var personName = $(this).attr("data-person-name"); //获取用户的姓名
            deletePersons(personId, personName);
        });

        //删除联系人
        function deletePersons(id, name) {
            abp.message.confirm("是否删除姓名为" + name + "的联系人",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _personService.deletePerson({ id: id }).done(function () {
                            refreshPersonList();
                        });
                    }
                }
            );
        }

        //绑定前端刷新事件
        $('#RefreshButton').click(function () {
            refreshPersonList();
        });

        //刷新
        function refreshPersonList() {
            location.reload(true);
        }
    });
})();