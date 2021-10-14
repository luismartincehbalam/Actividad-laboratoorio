const functions= require('./index');
const context= require('../testing/Context');
const { expect } = require('@jest/globals');

test('Http trigger example', async () => {
    const request = {
        query: { name: 'schuc'}
    };

    var iteration = 100;
    console.time('FUNCTION #1');
    for( var i = 0; i<iteration; i++ ) 
    {
        await functions(context, request);
    }
    console.timeEnd('FUNCTION #1');
    expect(context.res.body).toContain('W');
    expect(context.res.body).toEqual('Welcome, schuc');
    expect(context.log.mock.calls.length).toBe(200);

});