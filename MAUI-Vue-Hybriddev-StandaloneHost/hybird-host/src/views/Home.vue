<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png" />
    <div>
      <h3>foo:</h3>
      <button @click="getFoo">click to get foo</button>
      <br />
      <span>{{ foo }}</span>
    </div>
    <div>
      <h3>bar:</h3>
      <span>{{ bar }}</span>
    </div>
    <div>
      <button @click="add">click here to add</button>
      <span>click count:{{ cnt }}</span>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import HelloWorld from "@/components/HelloWorld.vue"; // @ is an alias to /src
import { GetAll, Add } from "@/api/fooService";

@Component({
  components: {
    HelloWorld,
  },
})
export default class Home extends Vue {
  foo: string = "";
  bar: string = "";
  cnt: number = 0;

  async created() {
    window["postBar"] = this.postBar;
  }
  async add() {
    this.cnt = await Add({ a: this.cnt, b: 1 });
  }

  async getFoo() {
    var foo = await GetAll(null);
    this.foo = foo;
  }

  async postBar(data) {
    this.bar = data;
    console.log("DotNet invocked the function with param:" + data);
    return this.bar;
  }
}
</script>
