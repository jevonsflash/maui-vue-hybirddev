
var app = new Vue({
    el: '#vue-app',
    data: {
        message: 'Page2!',
        showDialog: false,
        msg: '',
        input: 'test'
    },
    methods: {
        greet: function (content) {
            this.msg = content           
            alert('Hello ' + this.msg + '!')
        }
    })
