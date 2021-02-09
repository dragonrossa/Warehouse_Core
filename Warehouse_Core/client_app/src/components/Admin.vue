<template>
  <div class="admin">
    <p>{{ title }}</p>

    <!-- Details  -->

    <p>
      <router-link to="/edituser" v-bind:likes="42" username="matt"
        >{{ option1 }}

        <EditUser :v-bind="props" />
      </router-link>
    </p>

    <p>
      <router-link to="/roles" v-bind:likes="42">{{ option2 }}</router-link>
    </p>

    <router-view></router-view>
  </div>
</template>

<script>
import EditUser from "./Admin/EditUser.vue";

export default {
  name: "ParentComponent",
  mounted() {},
  props: {
    firstname: {
      type:String,
      value:"Bubu"
    },
  },
  components: {
    EditUser,
  },
  data() {
    return {
      title: "Admin",
      option1: "Edit user",
      option2: "Add role",
      likes1: this.likes,
    };
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
