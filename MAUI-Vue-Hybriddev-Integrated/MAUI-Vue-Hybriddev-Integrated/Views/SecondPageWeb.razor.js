
window.app = new Vue({
    el: '#vue-app',
    data: {
        message: 'Vue Native interop',
        showDialog: false,
        msg: '',
        input: 'Hi, I am a text message from Vue',
        deviceDisplay: null,
        objRef: null
    },
    methods: {
        greet: function (content) {
            this.msg = content;
            this.showDialog = true;
        },
        post: function () {
            this.objRef.invokeMethodAsync('Post', this.input);
        }


    },
    watch: {
        objRef: async function (newObjRef, oldObjRef) {
            if (newObjRef) {
                var deviceDisplay = await this.objRef.invokeMethodAsync('ReadDeviceDisplay');
                console.warn(deviceDisplay);
                this.deviceDisplay = deviceDisplay;
            }

        }
    },
})
window.initObjRef = function (objRef) {
    window.app.objRef = objRef;
}
