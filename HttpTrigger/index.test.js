const functions= require('./index');
const context= require('../testing/Context');
const { expect } = require('@jest/globals');

test('Http trigger', async () => {
    const request = {
        query: { name: 'schuc'}
    };

    await functions(context, request);
    expect(context.res.body).toEqual('Hello, schuc');
    debugger;
});