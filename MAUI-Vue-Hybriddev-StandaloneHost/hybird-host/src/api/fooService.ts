export async function GetAll(data) {
    var result = null
        await window['DotNet'].invokeMethodAsync('MatoProject', 'GetFoo')
            .then(data => {
                console.log("DotNet method return the value:" + data);
                result = data
            });
    return result
}


export async function Add(data) {
    var result = null
        await window['DotNet'].invokeMethodAsync('MatoProject', 'Add', data)
            .then(data => {
                console.log("DotNet method return the value:" + data);
                result = data
            });
    return result
}