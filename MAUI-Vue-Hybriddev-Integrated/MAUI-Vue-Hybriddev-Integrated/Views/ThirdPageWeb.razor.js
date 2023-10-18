
window.app = new Vue({
    el: '#vue-app',
    data: {
        message: 'Upload files',
        objRef: null,
        fileList:[]
    },
    methods: {
        handleRemove(file, fileList) {
            console.log(file, fileList);
        },
        handlePreview(file) {
            console.log(file);
        },
        handleExceed(files, fileList) {
            this.$message.warning(`当前限制选择 3 个文件，本次选择了 ${files.length} 个文件，共选择了 ${files.length + fileList.length} 个文件`);
        },
        beforeRemove(file, fileList) {
            return this.$confirm(`确定移除 ${file.name}？`);
        }


    },
})
window.initObjRef = function (objRef) {
    window.app.objRef = objRef;
}
