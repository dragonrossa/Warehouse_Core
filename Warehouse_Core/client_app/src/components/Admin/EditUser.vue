<template>
  <div class="admin">
    <div id="content">
    <p>{{ title }}</p>

    <!-- Details  -->
    <p>{{ name }}</p>
    </div>

    <router-view></router-view>
  </div>
</template>

<script>

export default {
 name: "HelloWorld2",
  props: {
    name: String,
  },
  data() {
    return {
      title: "Admin",
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped src="../../assets/style/warehouse_style.css">
</style>