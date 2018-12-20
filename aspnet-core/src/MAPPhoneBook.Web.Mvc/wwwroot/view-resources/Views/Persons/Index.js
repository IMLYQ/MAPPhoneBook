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

            //约定大约配置
            _personService.createOrUpdatePerson({ personEditDto }).done(function () {
                _$modal.modal('hide');  //隐藏模态框
                //重新加载数据
                location.reload(true);
            }).always(function () {
                abp.ui.clearBusy(_$modal);
                });
        });
    });
})();